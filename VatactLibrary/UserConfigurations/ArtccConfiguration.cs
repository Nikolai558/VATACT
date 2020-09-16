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
                    overWrite = MessageBox.Show("You can only have one custom configuration per ARTCC / FIR.\n\nWould you like to overwrite the current configuration?", "Overwrite?", MessageBoxButtons.YesNo);
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

                

                return isComplete;

            }

            isComplete = false;
            return isComplete;

        }

        public static void PutCustomArtccIntoGlobalConfig(string lineInConfigFile, string CustomArtccCode) 
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

            if (GlobalConfig.CustomArtccDictionary.ContainsKey(CustomArtccCode))
            {
                // TODO - HAVE TO ADD not SET
                if (!GlobalConfig.CustomArtccDictionary[CustomArtccCode].ContainsKey(cols[0]))
                {
                    GlobalConfig.CustomArtccDictionary[CustomArtccCode] = new Dictionary<string, List<string>> { { cols[0], new List<string>() } };
                    GlobalConfig.CustomArtccDictionary[CustomArtccCode][cols[0]] = output[cols[0]];
                }
                else
                {
                    GlobalConfig.CustomArtccDictionary[CustomArtccCode][cols[0]] = output[cols[0]];
                }
            }
            else
            {
                GlobalConfig.CustomArtccDictionary.Add(CustomArtccCode, new Dictionary<string, List<string>>());
                GlobalConfig.CustomArtccDictionary[CustomArtccCode].Add(cols[0], new List<string>());
                GlobalConfig.CustomArtccDictionary[CustomArtccCode][cols[0]] = output[cols[0]];
            }

            // TODO - Add the thing to ARTCC Dictionary
            if (GlobalConfig.ArtccDictionary.ContainsKey(CustomArtccCode))
            {
                // TODO - User is editing the Custom Config Artcc. Need to allow to edit.
                //MessageBox.Show("Can not edit Configuration yet.");
                if (GlobalConfig.ArtccDictionary[CustomArtccCode].ContainsKey(cols[0]))
                {
                    GlobalConfig.ArtccDictionary[CustomArtccCode][cols[0]] = output[cols[0]];
                }
                else
                {
                    GlobalConfig.ArtccDictionary[CustomArtccCode].Add(cols[0], new List<string>());
                    GlobalConfig.ArtccDictionary[CustomArtccCode][cols[0]] = output[cols[0]];
                }
            }
            else
            {
                GlobalConfig.ArtccDictionary.Add(CustomArtccCode, GlobalConfig.CustomArtccDictionary[CustomArtccCode]);
            }
        }

        public static void LoadCustomArtcc() 
        {
            string directoryPath = Application.LocalUserAppDataPath;
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath); 

            foreach (var file in directoryInfo.GetFiles("*.txt"))
            {
                string[] customArtccName = file.Name.Split('_');

                string[] fileLines = File.ReadAllLines(file.FullName);
                List<string> lines = new List<string>();

                foreach (string line in fileLines)
                {
                    if (line == "Prefix,DEL,GND,APP,DEP,CTR,FSS")
                    {
                        continue;
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
                
                foreach (string line in lines)
                {
                    PutCustomArtccIntoGlobalConfig(line, $"___{customArtccName[3]}___");
                }
            }
        }
    }
}
