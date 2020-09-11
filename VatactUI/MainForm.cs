using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatactUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Height = 325;
        }

        private void configureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void autoFindRadioButton_Click(object sender, EventArgs e)
        {
            // TODO - Need to implement Auto Find CID's
            NotImplementedMessage();
            autoFindRadioButton.Checked = false;
            txtFileRadioButton.Checked = true;
        }

        private void bothRadioButton_Click(object sender, EventArgs e)
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
    }
}
