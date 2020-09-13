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
        private static string selectedDefaultArtcc;
        private List<CheckBox> allSuffixCheckBoxes = new List<CheckBox>();
        private List<Label> allPrefixLabels = new List<Label>();

        public ConfigureArtccForm()
        {
            InitializeComponent();

            artccComboBox.DataSource = VatactLibrary.UserConfigurations.Default.defaultArtccDictionary.Keys.ToList();
        }

        private void CreatePrefixAndSuffixControls() 
        {
            Panel pan = configurationPanel;
            
            int id = 1;
            int prefixLabelLocationX = 72;
            int prefixLabelLoactionY = 10;

            int suffixLabelLocationX = 199;
            int suffixLabelLocationY = 10;



            foreach (string prefixLabel in VatactLibrary.UserConfigurations.Default.defaultArtccDictionary[selectedDefaultArtcc])
            {
                Point prefixLocation = new Point(prefixLabelLocationX, prefixLabelLoactionY);

                Label l = new Label();
                l.Name = $"{prefixLabel}{id}";
                l.Text = prefixLabel;
                l.Location = prefixLocation;
                pan.Controls.Add(l);
                allPrefixLabels.Add(l);

                foreach (string suffixLabel in VatactLibrary.UserConfigurations.Default.ControlSuffix)
                {
                    Point suffixLocation = new Point(suffixLabelLocationX, suffixLabelLocationY);

                    CheckBox c = new CheckBox();

                    c.Name = $"{suffixLabel}{id}";
                    c.Text = suffixLabel;
                    c.AutoSize = true;
                    c.Location = suffixLocation;

                    if (suffixLabel != "_FSS")
                    {
                        c.Checked = true;
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

        private void checkAllButton_Click(object sender, EventArgs e)
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
    }
}
