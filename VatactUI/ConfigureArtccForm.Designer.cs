namespace VatactUI
{
    partial class ConfigureArtccForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.configurationPanel = new System.Windows.Forms.Panel();
            this.callsignPrefixLabel = new System.Windows.Forms.Label();
            this.callsignSuffixlabel = new System.Windows.Forms.Label();
            this.instructionButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.checkAllButton = new System.Windows.Forms.Button();
            this.uncheckAllButton = new System.Windows.Forms.Button();
            this.autoPopulateButton = new System.Windows.Forms.Button();
            this.artccComboBox = new System.Windows.Forms.ComboBox();
            this.newArtccLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // configurationPanel
            // 
            this.configurationPanel.AutoScroll = true;
            this.configurationPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationPanel.Location = new System.Drawing.Point(17, 53);
            this.configurationPanel.Name = "configurationPanel";
            this.configurationPanel.Size = new System.Drawing.Size(859, 287);
            this.configurationPanel.TabIndex = 0;
            // 
            // callsignPrefixLabel
            // 
            this.callsignPrefixLabel.AutoSize = true;
            this.callsignPrefixLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callsignPrefixLabel.Location = new System.Drawing.Point(12, 20);
            this.callsignPrefixLabel.Name = "callsignPrefixLabel";
            this.callsignPrefixLabel.Size = new System.Drawing.Size(154, 30);
            this.callsignPrefixLabel.TabIndex = 1;
            this.callsignPrefixLabel.Text = "Callsign Prefix";
            // 
            // callsignSuffixlabel
            // 
            this.callsignSuffixlabel.AutoSize = true;
            this.callsignSuffixlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callsignSuffixlabel.Location = new System.Drawing.Point(211, 20);
            this.callsignSuffixlabel.Name = "callsignSuffixlabel";
            this.callsignSuffixlabel.Size = new System.Drawing.Size(155, 30);
            this.callsignSuffixlabel.TabIndex = 2;
            this.callsignSuffixlabel.Text = "Callsign Suffix";
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.Color.DimGray;
            this.instructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.instructionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionButton.Location = new System.Drawing.Point(17, 363);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(103, 53);
            this.instructionButton.TabIndex = 20;
            this.instructionButton.Text = "Instructions";
            this.instructionButton.UseVisualStyleBackColor = false;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DimGray;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(126, 363);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 53);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save Custom Config";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DimGray;
            this.resetButton.Enabled = false;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(773, 363);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 30);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // checkAllButton
            // 
            this.checkAllButton.BackColor = System.Drawing.Color.DimGray;
            this.checkAllButton.Enabled = false;
            this.checkAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllButton.Location = new System.Drawing.Point(551, 363);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(103, 30);
            this.checkAllButton.TabIndex = 23;
            this.checkAllButton.Text = "Check ALL";
            this.checkAllButton.UseVisualStyleBackColor = false;
            this.checkAllButton.Click += new System.EventHandler(this.CheckAllButton_Click);
            // 
            // uncheckAllButton
            // 
            this.uncheckAllButton.BackColor = System.Drawing.Color.DimGray;
            this.uncheckAllButton.Enabled = false;
            this.uncheckAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uncheckAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uncheckAllButton.Location = new System.Drawing.Point(660, 363);
            this.uncheckAllButton.Name = "uncheckAllButton";
            this.uncheckAllButton.Size = new System.Drawing.Size(107, 30);
            this.uncheckAllButton.TabIndex = 24;
            this.uncheckAllButton.Text = "Uncheck ALL";
            this.uncheckAllButton.UseVisualStyleBackColor = false;
            this.uncheckAllButton.Click += new System.EventHandler(this.uncheckAllButton_Click);
            // 
            // autoPopulateButton
            // 
            this.autoPopulateButton.BackColor = System.Drawing.Color.DimGray;
            this.autoPopulateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoPopulateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoPopulateButton.Location = new System.Drawing.Point(279, 362);
            this.autoPopulateButton.Name = "autoPopulateButton";
            this.autoPopulateButton.Size = new System.Drawing.Size(116, 30);
            this.autoPopulateButton.TabIndex = 25;
            this.autoPopulateButton.Text = "Auto Populate";
            this.autoPopulateButton.UseVisualStyleBackColor = false;
            this.autoPopulateButton.Click += new System.EventHandler(this.autoPopulateButton_Click);
            // 
            // artccComboBox
            // 
            this.artccComboBox.BackColor = System.Drawing.Color.DimGray;
            this.artccComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.artccComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artccComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.artccComboBox.FormattingEnabled = true;
            this.artccComboBox.Location = new System.Drawing.Point(401, 362);
            this.artccComboBox.Name = "artccComboBox";
            this.artccComboBox.Size = new System.Drawing.Size(110, 33);
            this.artccComboBox.TabIndex = 26;
            this.artccComboBox.SelectedIndexChanged += new System.EventHandler(this.artccComboBox_SelectedIndexChanged);
            // 
            // newArtccLinkLabel
            // 
            this.newArtccLinkLabel.AutoSize = true;
            this.newArtccLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newArtccLinkLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newArtccLinkLabel.LinkColor = System.Drawing.Color.LightGray;
            this.newArtccLinkLabel.Location = new System.Drawing.Point(291, 395);
            this.newArtccLinkLabel.Name = "newArtccLinkLabel";
            this.newArtccLinkLabel.Size = new System.Drawing.Size(92, 21);
            this.newArtccLinkLabel.TabIndex = 27;
            this.newArtccLinkLabel.TabStop = true;
            this.newArtccLinkLabel.Text = "New ARTCC";
            this.newArtccLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newArtccLinkLabel_LinkClicked);
            // 
            // ConfigureArtccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(894, 421);
            this.Controls.Add(this.newArtccLinkLabel);
            this.Controls.Add(this.artccComboBox);
            this.Controls.Add(this.autoPopulateButton);
            this.Controls.Add(this.uncheckAllButton);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.callsignSuffixlabel);
            this.Controls.Add(this.callsignPrefixLabel);
            this.Controls.Add(this.configurationPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ConfigureArtccForm";
            this.Text = "ConfigureArtccForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel configurationPanel;
        private System.Windows.Forms.Label callsignPrefixLabel;
        private System.Windows.Forms.Label callsignSuffixlabel;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.Button uncheckAllButton;
        private System.Windows.Forms.Button autoPopulateButton;
        private System.Windows.Forms.ComboBox artccComboBox;
        private System.Windows.Forms.LinkLabel newArtccLinkLabel;
    }
}