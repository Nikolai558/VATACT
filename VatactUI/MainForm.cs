using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatactLibrary;
using VatactLibrary.Models;

namespace VatactUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            artccComboBox.DataSource = GlobalConfig.ArtccDictionary.Keys.ToList();
            processingLabel.Visible = false;
            Height = 325;
        }

        private bool ValidateCalculateButton() 
        {
            bool isValid = true;
            string errorMessages = "The following Errors have occured:\n\n";

            if (txtFilePathTextBox.Text == "")
            {
                isValid = false;
                errorMessages += "CID Text File List File Path is empty.\n";
            }

            if (monthTextBox.Text == "")
            {
                isValid = false;
                errorMessages += "Month is empty.\n";
            }

            if (yearTextBox.Text == "")
            {
                isValid = false;
                errorMessages += "Year is empty.\n";
            }

            if (reqHoursTextBox.Text == "")
            {
                isValid = false;
                errorMessages += "Minimum Hours Required is empty.\n";
            }

            if (!File.Exists(txtFilePathTextBox.Text))
            {
                isValid = false;
                errorMessages += $"No such file exits: {txtFilePathTextBox.Text}\n";
            }

            if (monthTextBox.Text.Count() != 2)
            {
                isValid = false;
                errorMessages += "Month field is invalid.\n";
            }

            if (yearTextBox.Text.Count() != 4)
            {
                isValid = false;
                errorMessages += "Year field is invalid.\n";
            }

            if (reqHoursTextBox.Text.Count() != 2)
            {
                isValid = false;
                errorMessages += "Minimum Hours Required is invalid.\n";
            }

            if (!int.TryParse(monthTextBox.Text, out int output))
            {
                isValid = false;
                errorMessages += "Month field is invalid.\n";
            }

            if (output > 12 || output <= 00)
            {
                isValid = false;
                errorMessages += $"Month is not valid.\n";
            }

            if (!int.TryParse(yearTextBox.Text, out output))
            {
                isValid = false;
                errorMessages += "Year field is invalid.\n";
            }

            if (output > 2100 || output < 1950)
            {
                isValid = false;
                errorMessages += $"Year is either way to far in the future or past.\n";
            }

            if (!int.TryParse(reqHoursTextBox.Text, out output))
            {
                isValid = false;
                errorMessages += "Minimum Hours is Invalid.\n";
            }

            if (output > 99 || output <= 00)
            {
                isValid = false;
                errorMessages += $"Minimum Hours is either too big or to small.\n";
            }

            if (artccComboBox.SelectedItem == null)
            {
                isValid = false;
                errorMessages += "No ARTCC is selected.\n";
            }


            if (!isValid)
            {
                MessageBox.Show(errorMessages);
                return isValid;
            }
            else
            {
                return isValid;
            }
        }

        private void ConfigureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            configureLinkLabel.Enabled = false;
            Form frm = new ConfigureArtccForm();
            frm.Height = 445;
            frm.FormClosing += ConfigureFormClosingEventHandler;
            frm.Show();
            NotImplementedMessage();
        }

        private void ConfigureFormClosingEventHandler(object sender, FormClosingEventArgs e) 
        {
            configureLinkLabel.Enabled = true;
        }

        private void EnableFields(bool enable) 
        {
            txtFileRadioButton.Enabled = enable;
            autoFindRadioButton.Enabled = enable;
            bothRadioButton.Enabled = enable;
            configureLinkLabel.Enabled = enable;
            artccComboBox.Enabled = enable;
            calculateButton.Enabled = enable;

            txtFilePathTextBox.ReadOnly = !enable;
            monthTextBox.ReadOnly = !enable;
            yearTextBox.ReadOnly = !enable;
            reqHoursTextBox.ReadOnly = !enable;
        }

        private void AutoFindRadioButton_Click(object sender, EventArgs e)
        {
            // TODO - Need to implement Auto Find CID's
            NotImplementedMessage();
            autoFindRadioButton.Checked = false;
            txtFileRadioButton.Checked = true;
        }

        private void BothRadioButton_Click(object sender, EventArgs e)
        {
            //  - Need to implement Both Text List and Auto Find CID's
            NotImplementedMessage();
            bothRadioButton.Checked = false;
            txtFileRadioButton.Checked = true;
        }

        private void NotImplementedMessage() 
        {
            MessageBox.Show("This Has not be implemented yet.");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (ValidateCalculateButton())
            {
                EnableFields(false);

                //GlobalConfig.CidSource = null;

                GlobalConfig.TextFilePath = txtFilePathTextBox.Text;
                GlobalConfig.SelectedMonth = monthTextBox.Text;
                GlobalConfig.SelectedYear = yearTextBox.Text;
                GlobalConfig.SelectedRequiredHours = reqHoursTextBox.Text;
                GlobalConfig.SelectedArtcc = artccComboBox.SelectedItem.ToString();

                StartCalculations();
            }
        }

        private async void StartCalculations() 
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
                int totalCidsLeft = lines.Count();
                processingLabel.Visible = true;

                foreach (string line in lines)
                {

                    PersonModel person = new PersonModel
                    {
                        Id = id,
                        Cid = line
                    };

                    await VatactLibrary.DataAccess.ApiCallData.GetCidName(person);
                    await VatactLibrary.DataAccess.ApiCallData.GetCallsignsUsed(person);
                    VatactLibrary.DataAccess.DataManipulation.CalculateMinimumHoursRequirement(person);

                    if (!person.MetMinReqHours)
                    {
                        GlobalConfig.MinimumNotMetPeople.Add(person);
                    }

                    GlobalConfig.AllPeople.Add(person);

                    id += 1;
                    totalCidsLeft -= 1;

                    processingLabel.Text = $"** Processing ** {totalCidsLeft} CID's Left too Process **";
                    WireUpList();
                }

                processingLabel.Visible = false;
            }
        }

        private void WireUpList() 
        {
            if (!failedMinReqCheckBox.Checked)
            {
                controllerComboBox.DataSource = GlobalConfig.AllPeople;
                controllerComboBox.DisplayMember = "AllInfo";
            }
            else
            {
                controllerComboBox.DataSource = GlobalConfig.MinimumNotMetPeople;
                controllerComboBox.DisplayMember = "AllInfo";
            }

            if (GlobalConfig.selectedPerson.Count != 0 && GlobalConfig.selectedPerson.First() != null)
            {
                Height = 610;

                artccHoursLabel.Text = $"{artccComboBox.SelectedValue} Total Hours (hh:mm:ss): {GlobalConfig.selectedPerson.First().TotalArtccHours}";
                otherControlHoursLabel.Text = $"Other Total Hours (hh:mm:ss): {GlobalConfig.selectedPerson.First().TotalOtherHours}";

                artccCallsignListBox.DataSource = GlobalConfig.selectedPerson.First().ArtccCallsignsAndHours;
                otherCallsignListBox.DataSource = GlobalConfig.selectedPerson.First().OtherCallsignsAndHours;

                failedMinReqCheckBox.Text = $"Failed Hour Requirment Only ({GlobalConfig.MinimumNotMetPeople.Count}/{GlobalConfig.AllPeople.Count})";
            }
            else if (GlobalConfig.selectedPerson.Count == 0 || GlobalConfig.selectedPerson.First() == null)
            {
                Height = 325;

                failedMinReqCheckBox.Text = "Failed Hour Requirement Only";
            }


        }

        private void ControllerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)controllerComboBox.SelectedItem;

            if (GlobalConfig.selectedPerson.Count == 0)
            {
                GlobalConfig.selectedPerson.Add(person);
                WireUpList();
                return;
            }

            if (GlobalConfig.selectedPerson.First() != person)
            {
                GlobalConfig.selectedPerson.Clear();
                GlobalConfig.selectedPerson.Add(person);
                WireUpList();
                return;
            }
            else
            {
                return;
            }
        }

        private void FailedMinReqCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ResetAll() 
        {
            GlobalConfig.CidSource = null;
            GlobalConfig.TextFilePath = null;
            GlobalConfig.SelectedMonth = null;
            GlobalConfig.SelectedYear = null;
            GlobalConfig.SelectedRequiredHours = null;
            GlobalConfig.SelectedArtcc = null;
            GlobalConfig.SaveFileDirectory = null;

            GlobalConfig.AllPeople.Clear();
            GlobalConfig.MinimumNotMetPeople.Clear();
            GlobalConfig.selectedPerson.Clear();

            EnableFields(true);
            WireUpList();
    }
    }
}
