// ========================================
//  © Copyright. VISIONARY S.A.S.
// ========================================
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
// for binary protocol
//* using Microsoft.Extensions.DependencyInjection;

namespace MonitorTest
{
    /// <summary>
    /// SignalR from TransmitterUnit microservice, net6
    /// </summary>
    public class SignalsClient
    {
        public delegate void EmittOnlineRecordHandler(OnlineStatus onlineStatus);

        public event EmittOnlineRecordHandler EmitOnlineRecord = delegate { };

        HubConnection _hub;
        bool _active;
        string _uid;
        string _apiRoot;
        DateTime _t = new DateTime();

        const string HUB = "TU";
        const string NAME = "MONITOR";
        const int RECORD_VERSION = 3; //* best structure

        public bool Active => _active;

        public async Task<bool> ConnectAsync(string apiRoot, string uid)
        {
            _apiRoot = apiRoot;
            _uid = uid;

            if(await ExistsApiRoot() == false) {
                // if it doesn't exist it may take time to resolve
                return false;
            }

            _hub = new HubConnectionBuilder()
              .WithUrl(_apiRoot + HUB)
              //* .AddMessagePackProtocol()
              .WithAutomaticReconnect() //... is unsubscribe
              .Build();

            _hub.ServerTimeout = TimeSpan.FromMinutes(30);

            _hub.On<OnlineStatus>("notifyData", (onlineStatus) => {
                if(onlineStatus != null) {
                    if(_t < onlineStatus.Time) {// important. Evoid sending the same
                        _t = onlineStatus.Time;
                        EmitOnlineRecord(onlineStatus);
                    }
                }
            });

            _hub.Reconnected += OnReconnected;

            try {
                await _hub.StartAsync();
                if(_hub.State == HubConnectionState.Connected) {
                    await _hub.InvokeAsync("Subscribe", _uid, NAME, RECORD_VERSION);
                    return true;
                }
            }
            catch(Exception exception) {
                Trace.WriteLine("OnlineStatusSR" + exception.Message);
            }
            _active = false;
            return false;
        }

        async Task OnReconnected(string arg)
        {
            Trace.WriteLine($"Hub Reconnected({arg}) ... Unexpected");
            // will be subscribe again ...
            if(_active) {
                await Task.Delay(1000);
                await _hub.InvokeAsync("Subscribe", _uid, NAME, RECORD_VERSION);
            }
        }

        public async Task Dispose()
        {
            if(_active) {
                await _hub.DisposeAsync();
                await Task.Delay(1000);
            }
            _active = false;
        }

        /// <summary>
        /// Quick verification of the existence of the service, before executing SignalR connection
        /// </summary>
        /// <returns></returns>
        async Task<bool> ExistsApiRoot()
        {
            try {
                using(var client = new HttpClient()) {
                    client.BaseAddress = new Uri(_apiRoot);
                    var response = await client.GetAsync("api/Status/GetVersion");
                    if(response.StatusCode == HttpStatusCode.OK) {
                        Trace.WriteLine("Can access the API in " + _apiRoot);
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }
    }
}

