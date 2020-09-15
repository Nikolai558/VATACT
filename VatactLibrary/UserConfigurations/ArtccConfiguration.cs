using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatactLibrary.UserConfigurations
{
    public class ArtccConfiguration
    {
        public static bool SaveArtccConfiguration(Dictionary<string, List<CheckBox>> configuration, string artccCustomName) 
        {
            artccCustomName = $"___{artccCustomName}___";
            // C:\Users\%Username%\AppData\Local
            string directoryPath = Application.LocalUserAppDataPath ;
            string fullFilePath = $"{directoryPath}\\{artccCustomName}_Config.txt";
            bool isComplete;

            if (Directory.Exists(directoryPath))
            {
                List<string> outputLines = new List<string>() { "Prefix,DEL,GND,APP,DEP,CTR,FSS" };
                string output;

                foreach (string prefix in configuration.Keys.ToList())
                {
                    output = $"{prefix},";

                    foreach (CheckBox checkBox in configuration[prefix])
                    {
                        if (checkBox.Checked)
                        {
                            output += "true,";
                        }
                        else
                        {
                            output += "false,";
                        }
                    }

                    output = output.Substring(0, output.Count() - 1);
                    PutCustomArtccIntoGlobalConfig(output, artccCustomName);
                    outputLines.Add(output);
                }

                DialogResult overWrite = DialogResult.Yes;

                if (File.Exists(fullFilePath))
                {
                    overWrite = MessageBox.Show("You can only have one custom configuration per ARTCC.\n\nWould you like to overwrite the current configuration?", "Overwrite?", MessageBoxButtons.YesNo);
                }

                if (overWrite == DialogResult.Yes)
                {
                    File.WriteAllLines(fullFilePath, outputLines);
                    isComplete = true;

                }
                else
                {
                    isComplete = false;
                }

                // TODO - FOR TESTING PURPOSES
                //dicA.Concat(dicB).ToDictionary(kvp => kvp.Key, kvp => kvp.Value)

                if (GlobalConfig.ArtccDictionary.ContainsKey(artccCustomName))
                {
                    // TODO - User is editing the Custom Config Artcc. Need to allow to edit.
                    //MessageBox.Show("Can not edit Configuration yet.");
                }
                else
                {
                    GlobalConfig.ArtccDictionary.Add(artccCustomName, GlobalConfig.CustomArtccDictionary[artccCustomName]);
                }

                return isComplete;

            }

            isComplete = false;
            return isComplete;

        }

        public static void PutCustomArtccIntoGlobalConfig(string lineInConfigFile, string artccCode) 
        {
            string[] cols = lineInConfigFile.Split(',');
            string[] getRidOfId = cols[0].Split('_');
            cols[0] = getRidOfId[0];
            
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            output.Add(cols[0], new List<string>());

            if (cols[1] == "true")
            {
                output[cols[0]].Add("_DEL");
            }
            if (cols[2] == "true")
            {
                output[cols[0]].Add("_GND");
            }
            if (cols[3] == "true")
            {
                output[cols[0]].Add("_TWR");
            }
            if (cols[4] == "true")
            {
                output[cols[0]].Add("_APP");
            }
            if (cols[5] == "true")
            {
                output[cols[0]].Add("_DEP");
            }
            if (cols[6] == "true")
            {
                output[cols[0]].Add("_CTR");
            }
            if (cols[7] == "true")
            {
                output[cols[0]].Add("_FSS");
            }

            if (GlobalConfig.CustomArtccDictionary.ContainsKey(artccCode))
            {
                GlobalConfig.CustomArtccDictionary[artccCode] = new Dictionary<string, List<string>> { { cols[0], new List<string>() } };
                GlobalConfig.CustomArtccDictionary[artccCode][cols[0]] = output[cols[0]];
            }
            else
            {
                GlobalConfig.CustomArtccDictionary.Add(artccCode, new Dictionary<string, List<string>>());
                GlobalConfig.CustomArtccDictionary[artccCode].Add(cols[0], new List<string>());
                GlobalConfig.CustomArtccDictionary[artccCode][cols[0]] = output[cols[0]];
            }
        }

        public void LoadCustomArtcc(string artccCustomName) 
        {
            string directoryPath = Application.LocalUserAppDataPath;
            string fullFilePath = $"{directoryPath}\\{artccCustomName}_Config.txt";


        }
    }
}
