using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatactLibrary.DataAccess;
using VatactLibrary.Models;

namespace VatactLibrary
{
    public static class GlobalConfig
    {
        public static readonly string ProgramVersion = "V-0.0.8";

        public static Dictionary<string, List<string>> ArtccDictionary;
        public static List<string> ControlSuffix;

        public static string CidSource = null;
        public static string TextFilePath = null;
        public static int SelectedMonth = 0;
        public static int SelectedYear = 0;
        public static int SelectedRequiredHours = 0;
        public static string SelectedArtcc = null;
        public static string SaveFileDirectory = null;

        public static BindingList<PersonModel> AllPeople = new BindingList<PersonModel>();
        public static BindingList<PersonModel> MinimumNotMetPeople = new BindingList<PersonModel>();
        public static BindingList<PersonModel> selectedPerson = new BindingList<PersonModel>();

        public static void ConfigurationSetup(bool hasConfigurationFiles) 
        {
            // TODO - Set this up so it grabs either the default or the user configuration files! 
            if (!hasConfigurationFiles)
            {
                ArtccDictionary = UserConfigurations.Default.defaultArtccDictionary;
                ControlSuffix = UserConfigurations.Default.ControlSuffix;
            }
            else
            {

            }
        }

        public static void VersionCheck() 
        {
            (string currentVersion, string errorMessage) = ApiCallData.GetCurrentVersion();

            if (currentVersion != ProgramVersion)
            {
                MessageBox.Show("Program is out of date!\nPlease visit https://github.com/Nikolai558/VATACT/releases and update!");
            }
            else
            {
                return;
            }
        }

    }
}
