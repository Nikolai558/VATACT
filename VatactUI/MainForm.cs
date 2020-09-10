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
        }

        private void configureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            configureLinkLabel.Enabled = false;
            Form frm = new ConfigureArtccForm();
            frm.Height = 445;
            frm.Show();
            // TODO - Re-enable configure link after form closes.
        }
    }
}
