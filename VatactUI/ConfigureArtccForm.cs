using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatactUI
{
    public partial class ConfigureArtccForm : Form
    {
        private Dictionary<string, List<CheckBox>> configurationDictionary = new Dictionary<string, List<CheckBox>>();
        private static string selectedDefaultArtcc;
        private List<CheckBox> allSuffixCheckBoxes = new List<CheckBox>();
        private List<Label> allPrefixLabels = new List<Label>();
        private TextBox createNewTextbox;
        private List<CheckBox> createNewCheckBoxs = new List<CheckBox>();
        private LinkLabel createNewLinkLabel;

        public ConfigureArtccForm()
        {
            InitializeComponent();

            artccComboBox.DataSource = VatactLibrary.UserConfigurations.Default.defaultSetupArtccDictionary.Keys.ToList();
        }

        private void CreatePrefixAndSuffixControls() 
        {
            Panel pan = configurationPanel;
            
            int id = 1;
            int prefixLabelLocationX = 72;
            int prefixLabelLoactionY = 10;

            int suffixLabelLocationX = 199;
            int suffixLabelLocationY = 10;
            string workingKey = "";

            VatactLibrary.UserConfigurations.Default.defaultSetupArtccDictionary[selectedDefaultArtcc].Add("createNew");

            foreach (string prefixLabel in VatactLibrary.UserConfigurations.Default.defaultSetupArtccDictionary[selectedDefaultArtcc])
            {
                Point prefixLocation = new Point(prefixLabelLocationX, prefixLabelLoactionY);

                if (prefixLabel == "createNew")
                {
                    prefixLabelLocationX = 15;
                    prefixLabelLoactionY += 25;
                    prefixLocation = new Point(prefixLabelLocationX, prefixLabelLoactionY);

                    LinkLabel newPrefixLinkLabel= new LinkLabel();
                    newPrefixLinkLabel.Name = "newPrefixLinkLabel";
                    newPrefixLinkLabel.Text = "Create New Prefix";
                    newPrefixLinkLabel.AutoSize = true;
                    newPrefixLinkLabel.LinkColor = Color.LightGray;
                    newPrefixLinkLabel.Location = prefixLocation;
                    newPrefixLinkLabel.Click += new EventHandler(this.callsignPrefixLabel_click);
                    createNewLinkLabel = newPrefixLinkLabel;
                    pan.Controls.Add(newPrefixLinkLabel);

                    prefixLabelLocationX = 52;
                    prefixLabelLoactionY += 30;
                    suffixLabelLocationY = prefixLabelLoactionY;
                    prefixLocation = new Point(prefixLabelLocationX, prefixLabelLoactionY);

                    TextBox t = new TextBox();
                    createNewTextbox = t;
                    t.Name = "newPrefix";
                    t.Location = prefixLocation;
                    t.Height = 29;
                    t.Width = 97;
                    t.BorderStyle = BorderStyle.FixedSingle;
                    t.TextAlign = HorizontalAlignment.Center;
                    pan.Controls.Add(t);
                }
                else
                {
                    Label l = new Label();
                    l.Name = $"{prefixLabel}{id}".ToUpper();
                    l.Text = prefixLabel.ToUpper();
                    l.Location = prefixLocation;
                    workingKey = l.Name;
                    configurationDictionary.Add(workingKey, new List<CheckBox>());
                    pan.Controls.Add(l);
                    allPrefixLabels.Add(l);
                }

                foreach (string suffixLabel in VatactLibrary.UserConfigurations.Default.ControlSuffix)
                {
                    Point suffixLocation = new Point(suffixLabelLocationX, suffixLabelLocationY);

                    CheckBox c = new CheckBox();

                    c.Name = $"{suffixLabel}{id}".ToUpper();
                    c.Text = suffixLabel;
                    c.AutoSize = true;
                    c.Location = suffixLocation;

                    if (suffixLabel != "_FSS" && prefixLabel != "createNew")
                    {
                        c.Checked = true;
                    }

                    if (prefixLabel == "createNew")
                    {
                        createNewCheckBoxs.Add(c);
                    }


                    if (prefixLabel != "createNew")
                    {
                        configurationDictionary[workingKey].Add(c);
                    }
                    pan.Controls.Add(c);
                    allSuffixCheckBoxes.Add(c);

                    suffixLabelLocationX += 78;
                }

                id += 1;
                prefixLabelLoactionY += 40;
                suffixLabelLocationX = 199;
                suffixLabelLocationY = prefixLabelLoactionY;
            }

            VatactLibrary.UserConfigurations.Default.defaultSetupArtccDictionary[selectedDefaultArtcc].Remove("createNew");

        }

        private void callsignPrefixLabel_click(object sender, EventArgs e) 
        {
            if (validateNewPrefix())
            {
                CreateNewPrefixLabels();
            }

        }

        private void CreateNewPrefixLabels()
        {
            int newPrefixLocationY = allPrefixLabels.Last().Location.Y + 40;
            int prefixLocationX = 72;
            int lastPrefixId = allPrefixLabels.Count + 1;
            int suffixLabelLocationX = 199;
            int suffixLabelLocationY = newPrefixLocationY;
            int indexCreateNew = 0;
            Panel pan = configurationPanel;

            Point currentPoint;

            Point prefixLocation = new Point(prefixLocationX, newPrefixLocationY);

            Label l = new Label();
            l.Name = $"{createNewTextbox.Text}{lastPrefixId}".ToUpper();
            l.Text = createNewTextbox.Text.ToUpper();
            l.Location = prefixLocation;

            configurationDictionary.Add(l.Name, new List<CheckBox>());
            pan.Controls.Add(l);
            allPrefixLabels.Add(l);

            foreach (string suffixLabel in VatactLibrary.UserConfigurations.Default.ControlSuffix)
            {
                Point suffixLocation = new Point(suffixLabelLocationX, suffixLabelLocationY);

                CheckBox c = new CheckBox();

                c.Name = $"{suffixLabel}{lastPrefixId}".ToUpper();
                c.Text = suffixLabel;
                c.AutoSize = true;
                c.Location = suffixLocation;

                if (createNewCheckBoxs[indexCreateNew].Checked)
                {
                    c.Checked = true;
                }
                else
                {
                    c.Checked = false;
                }

                configurationDictionary[l.Name].Add(c);
                pan.Controls.Add(c);
                allSuffixCheckBoxes.Add(c);

                suffixLabelLocationX += 78;
                indexCreateNew += 1;
            }




            currentPoint = createNewLinkLabel.Location;
            currentPoint.Y += 40;
            createNewLinkLabel.Location = currentPoint;

            currentPoint = createNewTextbox.Location;
            currentPoint.Y += 40;
            createNewTextbox.Location = currentPoint;

            foreach (CheckBox checkBox in createNewCheckBoxs)
            {
                currentPoint = checkBox.Location;
                currentPoint.Y += 40;
                checkBox.Location = currentPoint;

            }
        }

        private bool validateNewPrefix() 
        {
            bool isValid = true;
            string errorMessage = "The following errors have occured:\n\n";

            if (createNewTextbox.Text == null || createNewTextbox.Text == "" || createNewTextbox.Text.Trim() == "_")
            {
                errorMessage += "Create new Prefix Text Box is Empty!\n";
                isValid = false;
                MessageBox.Show(errorMessage);
                return isValid;
            }
            if (createNewTextbox.Text.Count() > 5)
            {
                errorMessage += $"{createNewTextbox.Text} is not a valid entry. You can only have 5 Characters in the box!\n";
                isValid = false;
            }
            if (createNewTextbox.Text.Substring(createNewTextbox.Text.Count()-1) != "_")
            {
                errorMessage += $"You must have a '_' (underscore) ending your prefix!\n";
                isValid = false;
            }
            foreach (Char character in createNewTextbox.Text.ToList())
            {

            }
            
            
            
            
            if (!isValid)
            {
                MessageBox.Show(errorMessage);
            }
            return isValid;
        }

        private void artccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDefaultArtcc = artccComboBox.SelectedItem.ToString();
        }

        private void autoPopulateButton_Click(object sender, EventArgs e)
        {
            selectedDefaultArtcc = artccComboBox.SelectedItem.ToString();
            
            autoPopulateButton.Enabled = false;
            artccComboBox.Enabled = false;
            saveButton.Enabled = true;
            checkAllButton.Enabled = true;
            uncheckAllButton.Enabled = true;
            resetButton.Enabled = true;

            CreatePrefixAndSuffixControls();
        }

        private void CheckAllButton_Click(object sender, EventArgs e)
        {
            if (allSuffixCheckBoxes.Count != 0)
            {
                foreach (CheckBox checkBox in allSuffixCheckBoxes)
                {
                    checkBox.Checked = true;
                }
            }
        }

        private void uncheckAllButton_Click(object sender, EventArgs e)
        {
            if (allSuffixCheckBoxes.Count != 0)
            {
                foreach (CheckBox checkBox in allSuffixCheckBoxes)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Label label in allPrefixLabels)
            {
                label.Dispose();
            }
            foreach (CheckBox checkBox in allSuffixCheckBoxes)
            {
                checkBox.Dispose();
            }

            autoPopulateButton.Enabled = true;
            artccComboBox.Enabled = true;
            saveButton.Enabled = false;
            checkAllButton.Enabled = false;
            uncheckAllButton.Enabled = false;
            resetButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            startSave();
        }

        private void startSave() 
        {
            bool completeSave = VatactLibrary.UserConfigurations.ArtccConfiguration.SaveArtccConfiguration(configurationDictionary, artccComboBox.SelectedItem.ToString());

            if (completeSave)
            {
                Close();
            }
            else
            {
                return;
            }
        }

        private void newArtccLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Not Implemented Yet.");
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet.");

        }
    }
}
