using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatactLibrary
{
    public static class GlobalConfig
    {
        private static readonly List<string> ZLCControlPrefix = new List<string>() { "BIL_", "BOI_", "BZN_", "SUN_", "GPI_", "GTF_", "HLN_", "IDA_", "JAC_", "TWF_", "MSO_", "OGD_", "PIH_", "PVU_", "SLC_" };
        public static readonly List<string> ControlSuffix = new List<string>() { "_DEL", "_GND", "_TWR", "_APP", "_DEP", "_CTR" };

        public static readonly Dictionary<string, List<string>> ArtccDictionary = new Dictionary<string, List<string>>
        {
            { "ZLC", ZLCControlPrefix }
        };

        
        public static string SelectedArtcc = "";

    }
}
