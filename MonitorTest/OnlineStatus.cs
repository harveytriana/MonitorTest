// ========================================
//  © Copyright. VISIONARY S.A.S.
// ========================================
using System;
using System.Collections.Generic;

namespace MonitorTest
{
    public class OnlineStatus
    {
        public const float NULLF = -999.25F;

        public string Uid { get; set; }
        public DateTime Time { get; set; }
        public float Depth { get; set; }
        public int Activity { get; set; }

        public Dictionary<string, float> Mnemonics { get; set; } =
           new Dictionary<string, float>();

        public override string ToString() => $"{Time:dd-MM-yy HH:mm:ss}: {Uid} | {Depth:0.00} | N: {Mnemonics.Count}";

        public float GetValue(string mnemonic)
        {
            if(Mnemonics.ContainsKey(mnemonic)) {
                return Mnemonics[mnemonic];
            }
            return NULLF;
        }

        public void SetValue(string mnemonic, float value)
        {
            Mnemonics[mnemonic] = value;
        }
    }
}
