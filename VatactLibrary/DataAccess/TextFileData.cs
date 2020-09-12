using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatactLibrary.Models;

namespace VatactLibrary.DataAccess
{
    public class TextFileData
    {
        public async Task ReadCidList()
        {
            List<string> lines = File.ReadAllLines(GlobalConfig.TextFilePath).ToList();
            int id = 1;

            DialogResult dialogResult = DialogResult.Yes;

            if (lines.Count >= 30)
            {
                dialogResult = MessageBox.Show($"There are {lines.Count} CID's in your file.\nThis could take some time.\n\nWould you like to continue?", "Continue?", MessageBoxButtons.YesNo);
            }

            if (dialogResult == DialogResult.Yes)
            {
                foreach (string line in lines)
                {
                    PersonModel p = new PersonModel
                    {
                        Id = id,
                        Cid = line
                    };
                    await ApiCallData.GetCidName(p);
                    await ApiCallData.GetCallsignsUsed(p);
                    DataManipulation.CalculateMinimumHoursRequirement(p);

                    if (!p.MetMinReqHours)
                    {
                        GlobalConfig.MinimumNotMetPeople.Add(p);
                    }
                    GlobalConfig.AllPeople.Add(p);

                    id += 1;
                }
            }
        }

        public static void WriteToTextFile(List<PersonModel> people)
        {
            string filePath = $"{GlobalConfig.SaveFileDirectory}\\{GlobalConfig.SelectedMonth}_{GlobalConfig.SelectedYear}_CID_HOURS.txt";

            if (File.Exists(filePath))
            {
                DialogResult dialogResult = MessageBox.Show("CID Hour Calculation for selected Month and year Found.\nWould you like to overwrite it?", "Overide File?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    // TODO - Re-enable the "Save Button"
                    return;
                }
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**************************************************"); //40
            sb.AppendLine($"***********  CID HOURS FOR {GlobalConfig.SelectedYear} / {GlobalConfig.SelectedMonth}  ************");
            sb.AppendLine($"***********  Total CID's Checked: {people.Count()}  ************");
            sb.AppendLine("**************************************************");
            sb.AppendLine($"\nNOTE: ALL TIMES ARE FORMATED AS HH:MM:SS");
            sb.AppendLine($"\nThe following have not met the {GlobalConfig.SelectedArtcc} Minimum ({GlobalConfig.SelectedRequiredHours}) Hours:");
            foreach (PersonModel person in people)
            {
                if (!person.MetMinReqHours)
                {
                    sb.AppendLine($"\t\t{person.AllInfo}: {person.TotalArtccHours}");
                }
            }
            sb.AppendLine("\n\n::::::::::::::::::::::::::::::::::::::::::::::::::");
            foreach (PersonModel p in people)
            {
                sb.AppendLine($"{p.AllInfo}");

                sb.AppendLine($"\nTotal {GlobalConfig.SelectedArtcc} Hours: {p.TotalArtccHours}");

                if (p.ArtccCallsigns.Count > 0)
                {
                    foreach (string artccCallsign in p.ArtccCallsigns)
                    {
                        double totalTimeOnCallsign = 0;
                        foreach (CallsignModel callsignModel in p.AllCallsigns)
                        {
                            if (callsignModel.Callsign == artccCallsign)
                            {
                                totalTimeOnCallsign += callsignModel.MinutesOnCallsign;
                            }
                        }

                        TimeSpan time = TimeSpan.FromMinutes(totalTimeOnCallsign);
                        string hours = $"{(int)time.TotalHours}:{time.Minutes}:{time.Seconds}";

                        sb.AppendLine($"\t\t{artccCallsign} - {hours}");
                    }
                }
                else
                {
                    sb.AppendLine($"\t\tNone");
                }

                sb.AppendLine($"\nTotal Other Hours: {p.TotalOtherHours}");

                if (p.OtherCallsigns.Count > 0)
                {
                    foreach (string otherCallsign in p.OtherCallsigns)
                    {
                        double totalTimeOnOtherCallsign = 0;
                        foreach (CallsignModel callsignModel in p.AllCallsigns)
                        {
                            if (callsignModel.Callsign == otherCallsign)
                            {
                                totalTimeOnOtherCallsign += callsignModel.MinutesOnCallsign;
                            }
                        }

                        TimeSpan time = TimeSpan.FromMinutes(totalTimeOnOtherCallsign);
                        string hours = $"{(int)time.TotalHours}:{time.Minutes}:{time.Seconds}";
                        sb.AppendLine($"\t\t{otherCallsign} - {hours}");
                    }
                }
                else
                {
                    sb.AppendLine($"\t\tNone");
                }

                sb.AppendLine("::::::::::::::::::::::::::::::::::::::::::::::::::");
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
