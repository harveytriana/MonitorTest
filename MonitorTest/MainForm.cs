// ========================================
//  © Copyright. VISIONARY S.A.S.
// ========================================
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorTest
{
    public partial class MainForm : Form
    {
        readonly SignalsClient _signalsClient = new SignalsClient();

        public MainForm()
        {
            InitializeComponent();

            buttonConnect.Click += async (s, e) => await ConnectService();
            FormClosing += async (s, e) => await Exit();

            // no ugly selected
            textBoxApiRoot.Select(0, 0);
        }

        async Task ConnectService()
        {
            Echo("Connectiong...");

            if(await _signalsClient.ConnectAsync(ApiRoot, Uid)) {
                _signalsClient.EmitOnlineRecord += ReceiveOnlineRecord;
                // 
                buttonConnect.Enabled = false;
                Echo("Online...");
                textBoxData.Text = "Wait ACQ Signals..";
            }
            else {
                Echo("Connection Error");
            }
        }

        private void ReceiveOnlineRecord(OnlineStatus onlineStatus)
        {
            // here you have all the data available to display

            // only by example
            var sb = new StringBuilder();

            sb.AppendLine($"Online Time   : {onlineStatus.Time:dd-MM-yyyy HH:mm:ss}");
            sb.AppendLine($"Measure Depth : {onlineStatus.Depth:0.00}");
            foreach(var mnemocic in onlineStatus.Mnemonics.Keys) {
                sb.AppendLine($"{mnemocic}: {onlineStatus.Mnemonics[mnemocic]}");
            }
            textBoxData.Text = sb.ToString();
        }

        void Echo(string text)
        {
            textBoxData.Text = text;
        }

        string ApiRoot
        {
            get => textBoxApiRoot.Text;
            set => textBoxApiRoot.Text = value;
        }

        string Uid
        {
            get => textBoxUid.Text;
            set => textBoxUid.Text = value;
        }

        async Task Exit()
        {
            Echo("Closing...");
            if(_signalsClient.Active) {
                _signalsClient.EmitOnlineRecord -= ReceiveOnlineRecord;
                await _signalsClient.Dispose();
            }
        }
    }
}
