using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatactLibrary.UserConfigurations
{
    public static class Default
    {
        private static readonly List<string> ZLCControlPrefix = new List<string>() { "BIL_", "BOI_", "BZN_", "SUN_", "GPI_", "GTF_", "HLN_", "IDA_", "JAC_", "TWF_", "MSO_", "OGD_", "PIH_", "PVU_", "SLC_" };
        private static readonly List<string> ZDVControlPrefix = new List<string>() { "ASE_", "BKF_", "COS_", "AFF_", "BJC_", "APA_", "DEN_", "CFO_", "EGE_", "FCS_", "GJT_", "PUB_", "FMN_", "RCA_", "RAP_", "CPR_", "CYS_", "GCC_", "GUR_" };
        private static readonly List<string> ZLAControlPrefix = new List<string>() { "IFP_", "GCN_", "NYL_", "LGF_", "BFL_", "BUR_", "CMA_", "CRQ_", "NID_", "CNO_", "EDW_", "NJK_", "EMT_", "FUL_", "HHR_", "NRS_", "WJF_", "POC_", "VBG_", "LGB_", "SLI_", "LAX_", "WHP_", "MHV_", "NFG_", "ONT_", "OXR_", "PMD_", "PSP_", "NTD_", "RNM_", "RAL_", "RIV_", "SBD_", "NUC_", "SEE_", "MYF_", "SAN_", "NKX_", "NZY_", "SDM_", "SBP_", "NSI_", "SNA_", "SBA_", "SMX_", "SMO_", "TOA_", "VNY_", "VCV_", "INS_", "LSV_", "VGT_", "LAS_", "HND_", "TNX_" };
        private static readonly List<string> ZOAControlPrefix = new List<string>() { "CIC_", "CCR_", "SUU_", "FAT_", "HWD_", "NLC_", "LVK_", "BAB_", "MER_", "MOD_", "MRY_", "NUQ_", "APC_", "OAK_", "PAO_", "RDD_", "SMF_", "MHR_", "SAC_", "SNS_", "SQL_", "SFO_", "RHV_", "SJC_", "STS_", "SCK_", "TRK_", "NFL_", "RNO_" };
        private static readonly List<string> ZSEControlPrefix = new List<string>() { "LWS_", "UAO_", "EUG_", "LMT_", "MFR_", "OTH_", "PDT_", "PDX_", "HIO_", "TTD_", "RDM_", "SLE_", "PAE_", "GRF_", "MWH_", "NUW_", "OLM_", "PSC_", "RNT_", "SEA_", "BFI_", "GEG_", "SFF_", "SKA_", "TCM_", "TIW_", "ALW_", "YKM_" };

        private static readonly List<string> ZABControlPrefix = new List<string>() { "CHD_", "FLG_", "FHU_", "GXF_", "GEU_", "LUF_", "GYR_", "FFZ_", "DVT_", "IWA_", "PHX_", "PCA_", "PRC_", "SDL_", "TUS_", "DMA_", "RYN_", "HMN_", "AEG_", "ABQ_", "CVS_", "ROW_", "SAF_", "AMA_", "ELP_", "BIF_" };
        private static readonly List<string> ZTLControlPrefix = new List<string>() { "BHM_", "MXF_", "MGM_", "TCL_", "AHN_", "FTY_", "ATL_", "RYY_", "PDK_", "AGS_", "CSG_", "LSF_", "LZU_", "MCN_", "MGE_", "WRB_", "VUJ_", "AVL_", "CLT_", "JQF_", "GSO_", "HKY_", "INT_", "GMU_", "GYH_", "GSP_", "TRI_", "CHA_", "TYS_" };
        private static readonly List<string> ZFWControlPrefix = new List<string>() { "TXK_", "BAD_", "MLU_", "SHV_", "DTN_", "HOB_", "LTS_", "ADM_", "CSM_", "FSI_", "LAW_", "OUN_", "TIK_", "OKC_", "PWA_", "DYS_", "ABI_", "GKY_", "RBD_", "ADS_", "TKI_", "DFW_", "DAL_", "DTO_", "GRK_", "HLR_", "22XS", "FTW_", "NFW_", "FWS_", "AFW_", "GPM_", "GVT_", "GGG_", "LBB_", "HQZ_", "MAF_", "SJT_", "GYI_", "TYR_", "ACT_", "CNW_", "SPS_" };
        private static readonly List<string> ZHUControlPrefix = new List<string>() { "BFM_", "MOB_", "AEX_", "BTR_", "POE_", "HDC_", "HUM_", "LFT_", "LCH_", "CWF_", "ARA_", "NBG_", "MSY_", "NEW_", "HSA_", "BIX_", "SLJ_", "SH1_", "GPT_", "PQL_", "AUS_", "HYI_", "EDC_", "BPT_", "BRO_", "CLL_", "CRP_", "NGW_", "NGP_", "NWL_", "DLF_", "GLS_", "GTU_", "HRL_", "EFD_", "SGR_", "HOU_", "IAH_", "TME_", "CXO_", "DWH_", "NQI_", "LRD_", "MFE_", "BAZ_", "NOG_", "SKF_", "SSF_", "SAT_", "RND_", "VCT_" };
        private static readonly List<string> ZJXControlPrefix = new List<string>() { "DHN_", "OZR_", "HEY_", "LOR_", "FHK_", "SXS_", "TOI_", "2CB_", "COF_", "XMR_", "DAB_", "DTS_", "GNV_", "JAX_", "VQQ_", "CRG_", "NIP_", "NEN_", "LCQ_", "LEE_", "HRT_", "NRB_", "MLB_", "NDZ_", "NSE_", "NFJ_", "EVB_", "OCF_", "MCO_", "SFB_", "ISM_", "ORL_", "OMN_", "FIN_", "PAM_", "ECP_", "PNS_", "NPA_", "SGJ_", "TLH_", "TTS_", "TIX_", "VPS_", "EGI_", "ABY_", "EZM_", "LHW_", "SVN_", "SAV_", "VLD_", "VAD_", "NBC_", "CHS_", "CAE_", "MMT_", "FLO_", "HXD_", "MYR_", "CRE_", "SSC_" };
        private static readonly List<string> ZKCControlPrefix = new List<string>() { "ALN_", "BLV_", "CPS_", "MDH_", "MWA_", "SPI_", "FRI_", "GCK_", "HUT_", "MHK_", "IXD_", "OJC_", "SLN_", "TOP_", "FOE_", "BEC_", "ICT_", "IAB_", "BBG_", "COU_", "TBN_", "JEF_", "JLN_", "MKC_", "MCI_", "SZL_", "STJ_", "STL_", "SUS_", "SGF_", "WDG_", "END_", "SWO_", "RVS_", "TUL_" };
        private static readonly List<string> ZMEControlPrefix = new List<string>() { "HSV_", "HUA_", "FYV_", "XNA_", "FSM_", "LRF_", "LIT_", "ROG_", "ASG_", "HOP_", "PAH_", "CGI_", "GTR_", "CBM_", "GLH_", "GWO_", "JAN_", "HKS_", "MEI_", "NMM_", "NJW_", "OLV_", "TUP_", "EOD_", "MKL_", "MEM_", "NQA_", "BNA_", "MQY_" };
        private static readonly List<string> ZMAControlPrefix = new List<string>() { "BOW_", "BCT_", "BKV_", "FLL_", "FXE_", "FMY_", "RSW_", "FPR_", "HWO_", "HST_", "06FA", "EYW_", "NQX_", "LAL_", "TMB_", "MIA_", "OPF_", "APF_", "PMP_", "PGD_", "SPG_", "PIE_", "SRQ_", "SUA_", "TPA_", "MCF_", "VRB_", "PBI_", "MYGF", "MYNN", "MBGT", "MBPV" };

        private static readonly List<string> ZBWControlPrefix = new List<string>() { "GON_", "HFD_", "BDL_", "BED_", "BVY_", "BOS_", "FMH_", "HYA_", "LWM_", "ACK_", "EWB_", "OWD_", "CEF_", "MVY_", "BAF_", "ORH_", "BGR_", "PWM_", "LEB_", "MHT_", "ASH_", "PSM_", "ALB_", "GTB_", "RME_", "SCH_", "SYR_", "OQU_", "PVD_", "BTV_" };
        private static readonly List<string> ZAUControlPrefix = new List<string>() { "CID_", "DBQ_", "ALO_", "BMI_", "CMI_", "UGN_", "ARR_", "MDW_", "ORD_", "PWK_", "DPA_", "DEC_", "MLI_", "PIA_", "RFD_", "EKM_", "FWA_", "GYY_", "LAF_", "GUS_", "SBN_", "BTL_", "GRR_", "AZO_", "MKG_", "VOK_", "JVL_", "ENW_", "MSN_", "MWC_", "MKE_", "OSH_", "CMY_", "UES_" };
        private static readonly List<string> ZOBControlPrefix = new List<string>() { "ARB_", "DET_", "DTW_", "YIP_", "FNT_", "JXN_", "LAN_", "MTC_", "PTK_", "MBS_", "BUF_", "IAG_", "ROC_", "CAK_", "CLE_", "CGF_", "BKL_", "MFD_", "TOL_", "YNG_", "BVI_", "ERI_", "JST_", "LBE_", "AGC_", "PIT_", "CKB_", "MGW_", "HLG_" };
        private static readonly List<string> ZIDControlPrefix = new List<string>() { "AID_", "BMG_", "BAK_", "EVV_", "IND_", "MIE_", "HBE_", "HUF_", "CVG_", "FTK_", "LEX_", "SDF_", "LOU_", "OWB_", "LUK_", "TZR_", "LCK_", "OSU_", "CMH_", "DAY_", "FFO_", "ILN_", "CRW_", "HTS_", "PKB_" };
        private static readonly List<string> ZMPControlPrefix = new List<string>() { "DSM_", "SUX_", "APN_", "GOV_", "SAW_", "TVC_", "RYM_", "DLH_", "MIC_", "MSP_", "FCM_", "ANE_", "RST_", "STC_", "STP_", "BIS_", "FAR_", "GFK_", "RDR_", "MIB_", "MOT_", "GRI_", "LNK_", "OFF_", "OMA_", "FSD_", "ATW_", "EAU_", "GRB_", "LSE_", "CWA_" };
        private static readonly List<string> ZNYControlPrefix = new List<string>() { "BDR_", "DXR_", "HVN_", "OXC_", "JSD_", "ILG_", "CDW_", "NEL_", "MMU_", "EWR_", "TEB_", "TTN_", "WRI_", "BGM_", "HTO_", "ELM_", "FRG_", "ITH_", "SWF_", "ISP_", "NY22", "JFK_", "LGA_", "POU_", "FOK_", "HPN_", "ABE_", "MUI_", "CXY_", "MDT_", "LNS_", "PHL_", "PNE_", "RDG_", "UNV_", "AVP_", "IPT_", "TXKF" };
        private static readonly List<string> ZDCControlPrefix = new List<string>() { "DCA_", "IAD_", "HEF_", "JPN_", "DOV_", "APG_", "MTN_", "BWI_", "ADW_", "ESN_", "FDK_", "HGR_", "NHK_", "NUI_", "SBY_", "HFF_", "NKT_", "ECG_", "FAY_", "POB_", "FBG_", "GSB_", "NCA_", "OAJ_", "ISO_", "EWN_", "13NC", "RDU_", "NJM_", "ILM_", "ACY_", "BKT_", "CHO_", "DAA_", "FAF_", "LFI_", "LYH_", "PHF_", "NGU_", "ORF_", "NYG_", "RIC_", "ROA_", "NTU_", "WAL_", "LWB_", "MRB_" };

        /// <summary>
        /// Default Control Suffix's
        /// </summary>
        public static readonly List<string> ControlSuffix = new List<string>() { "_DEL", "_GND", "_TWR", "_APP", "_DEP", "_CTR", "_FSS" };

        /// <summary>
        /// Default Artcc Dictionary
        /// </summary>
        public static readonly Dictionary<string, List<string>> defaultArtccDictionary = new Dictionary<string, List<string>>
        {
            // Western Region (USA 7)
            { "ZLC", ZLCControlPrefix },
            { "ZDV", ZDVControlPrefix },
            { "ZLA", ZLAControlPrefix },
            { "ZOA", ZOAControlPrefix },
            { "ZSE", ZSEControlPrefix },

            // Southern Region (USA 8)
            { "ZAB", ZABControlPrefix },
            { "ZTL", ZTLControlPrefix },
            { "ZFW", ZFWControlPrefix },
            { "ZHU", ZHUControlPrefix },
            { "ZJX", ZJXControlPrefix },
            { "ZKC", ZKCControlPrefix },
            { "ZME", ZMEControlPrefix },
            { "ZMA", ZMAControlPrefix },

            // Northeastern Region (USA 9)
            { "ZBW", ZBWControlPrefix },
            { "ZAU", ZAUControlPrefix },
            { "ZOB", ZOBControlPrefix },
            { "ZID", ZIDControlPrefix },
            { "ZMP", ZMPControlPrefix },
            { "ZNY", ZNYControlPrefix },
            { "ZDC", ZDCControlPrefix },
        };
    }
}
