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
            this.templatePrefixLabel = new System.Windows.Forms.Label();
            this.templateDelCheckBox = new System.Windows.Forms.CheckBox();
            this.templateGndCheckBox = new System.Windows.Forms.CheckBox();
            this.templateAppCheckBox = new System.Windows.Forms.CheckBox();
            this.templateDepCheckBox = new System.Windows.Forms.CheckBox();
            this.templateCtrCheckBox = new System.Windows.Forms.CheckBox();
            this.templateFssCheckBox = new System.Windows.Forms.CheckBox();
            this.templateNotUsedRadioButton = new System.Windows.Forms.RadioButton();
            this.templateNewPrefixTextBox = new System.Windows.Forms.TextBox();
            this.templateNewNotUsedRadioButton = new System.Windows.Forms.RadioButton();
            this.templateNewFssCheckBox = new System.Windows.Forms.CheckBox();
            this.templateNewCtrCheckBox = new System.Windows.Forms.CheckBox();
            this.templateNewDepCheckBox = new System.Windows.Forms.CheckBox();
            this.templateNewAppCheckBox = new System.Windows.Forms.CheckBox();
            this.templateNewGndCheckBox = new System.Windows.Forms.CheckBox();
            this.templateNewDelCheckBox = new System.Windows.Forms.CheckBox();
            this.templatesGroupBox = new System.Windows.Forms.GroupBox();
            this.instructionButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.checkAllButton = new System.Windows.Forms.Button();
            this.uncheckAllButton = new System.Windows.Forms.Button();
            this.autoPopulateButton = new System.Windows.Forms.Button();
            this.artccComboBox = new System.Windows.Forms.ComboBox();
            this.templatesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // configurationPanel
            // 
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
            // templatePrefixLabel
            // 
            this.templatePrefixLabel.AutoSize = true;
            this.templatePrefixLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatePrefixLabel.Location = new System.Drawing.Point(72, 31);
            this.templatePrefixLabel.Name = "templatePrefixLabel";
            this.templatePrefixLabel.Size = new System.Drawing.Size(77, 21);
            this.templatePrefixLabel.TabIndex = 3;
            this.templatePrefixLabel.Text = "@@@@_";
            // 
            // templateDelCheckBox
            // 
            this.templateDelCheckBox.AutoSize = true;
            this.templateDelCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateDelCheckBox.Location = new System.Drawing.Point(199, 30);
            this.templateDelCheckBox.Name = "templateDelCheckBox";
            this.templateDelCheckBox.Size = new System.Drawing.Size(63, 25);
            this.templateDelCheckBox.TabIndex = 4;
            this.templateDelCheckBox.Text = "_DEL";
            this.templateDelCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateGndCheckBox
            // 
            this.templateGndCheckBox.AutoSize = true;
            this.templateGndCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateGndCheckBox.Location = new System.Drawing.Point(276, 29);
            this.templateGndCheckBox.Name = "templateGndCheckBox";
            this.templateGndCheckBox.Size = new System.Drawing.Size(70, 25);
            this.templateGndCheckBox.TabIndex = 5;
            this.templateGndCheckBox.Text = "_GND";
            this.templateGndCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateAppCheckBox
            // 
            this.templateAppCheckBox.AutoSize = true;
            this.templateAppCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateAppCheckBox.Location = new System.Drawing.Point(360, 30);
            this.templateAppCheckBox.Name = "templateAppCheckBox";
            this.templateAppCheckBox.Size = new System.Drawing.Size(64, 25);
            this.templateAppCheckBox.TabIndex = 6;
            this.templateAppCheckBox.Text = "_APP";
            this.templateAppCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateDepCheckBox
            // 
            this.templateDepCheckBox.AutoSize = true;
            this.templateDepCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateDepCheckBox.Location = new System.Drawing.Point(438, 30);
            this.templateDepCheckBox.Name = "templateDepCheckBox";
            this.templateDepCheckBox.Size = new System.Drawing.Size(64, 25);
            this.templateDepCheckBox.TabIndex = 7;
            this.templateDepCheckBox.Text = "_DEP";
            this.templateDepCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateCtrCheckBox
            // 
            this.templateCtrCheckBox.AutoSize = true;
            this.templateCtrCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateCtrCheckBox.Location = new System.Drawing.Point(516, 30);
            this.templateCtrCheckBox.Name = "templateCtrCheckBox";
            this.templateCtrCheckBox.Size = new System.Drawing.Size(64, 25);
            this.templateCtrCheckBox.TabIndex = 8;
            this.templateCtrCheckBox.Text = "_CTR";
            this.templateCtrCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateFssCheckBox
            // 
            this.templateFssCheckBox.AutoSize = true;
            this.templateFssCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateFssCheckBox.Location = new System.Drawing.Point(594, 30);
            this.templateFssCheckBox.Name = "templateFssCheckBox";
            this.templateFssCheckBox.Size = new System.Drawing.Size(62, 25);
            this.templateFssCheckBox.TabIndex = 9;
            this.templateFssCheckBox.Text = "_FSS";
            this.templateFssCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateNotUsedRadioButton
            // 
            this.templateNotUsedRadioButton.AutoSize = true;
            this.templateNotUsedRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNotUsedRadioButton.Location = new System.Drawing.Point(670, 28);
            this.templateNotUsedRadioButton.Name = "templateNotUsedRadioButton";
            this.templateNotUsedRadioButton.Size = new System.Drawing.Size(93, 25);
            this.templateNotUsedRadioButton.TabIndex = 10;
            this.templateNotUsedRadioButton.TabStop = true;
            this.templateNotUsedRadioButton.Text = "Not Used";
            this.templateNotUsedRadioButton.UseVisualStyleBackColor = true;
            // 
            // templateNewPrefixTextBox
            // 
            this.templateNewPrefixTextBox.BackColor = System.Drawing.Color.DimGray;
            this.templateNewPrefixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.templateNewPrefixTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewPrefixTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.templateNewPrefixTextBox.Location = new System.Drawing.Point(52, 78);
            this.templateNewPrefixTextBox.Name = "templateNewPrefixTextBox";
            this.templateNewPrefixTextBox.Size = new System.Drawing.Size(97, 29);
            this.templateNewPrefixTextBox.TabIndex = 11;
            this.templateNewPrefixTextBox.Text = "New";
            this.templateNewPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // templateNewNotUsedRadioButton
            // 
            this.templateNewNotUsedRadioButton.AutoSize = true;
            this.templateNewNotUsedRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewNotUsedRadioButton.Location = new System.Drawing.Point(670, 77);
            this.templateNewNotUsedRadioButton.Name = "templateNewNotUsedRadioButton";
            this.templateNewNotUsedRadioButton.Size = new System.Drawing.Size(93, 25);
            this.templateNewNotUsedRadioButton.TabIndex = 18;
            this.templateNewNotUsedRadioButton.TabStop = true;
            this.templateNewNotUsedRadioButton.Text = "Not Used";
            this.templateNewNotUsedRadioButton.UseVisualStyleBackColor = true;
            // 
            // templateNewFssCheckBox
            // 
            this.templateNewFssCheckBox.AutoSize = true;
            this.templateNewFssCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewFssCheckBox.Location = new System.Drawing.Point(594, 79);
            this.templateNewFssCheckBox.Name = "templateNewFssCheckBox";
            this.templateNewFssCheckBox.Size = new System.Drawing.Size(62, 25);
            this.templateNewFssCheckBox.TabIndex = 17;
            this.templateNewFssCheckBox.Text = "_FSS";
            this.templateNewFssCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateNewCtrCheckBox
            // 
            this.templateNewCtrCheckBox.AutoSize = true;
            this.templateNewCtrCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewCtrCheckBox.Location = new System.Drawing.Point(516, 79);
            this.templateNewCtrCheckBox.Name = "templateNewCtrCheckBox";
            this.templateNewCtrCheckBox.Size = new System.Drawing.Size(64, 25);
            this.templateNewCtrCheckBox.TabIndex = 16;
            this.templateNewCtrCheckBox.Text = "_CTR";
            this.templateNewCtrCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateNewDepCheckBox
            // 
            this.templateNewDepCheckBox.AutoSize = true;
            this.templateNewDepCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewDepCheckBox.Location = new System.Drawing.Point(438, 79);
            this.templateNewDepCheckBox.Name = "templateNewDepCheckBox";
            this.templateNewDepCheckBox.Size = new System.Drawing.Size(64, 25);
            this.templateNewDepCheckBox.TabIndex = 15;
            this.templateNewDepCheckBox.Text = "_DEP";
            this.templateNewDepCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateNewAppCheckBox
            // 
            this.templateNewAppCheckBox.AutoSize = true;
            this.templateNewAppCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewAppCheckBox.Location = new System.Drawing.Point(360, 79);
            this.templateNewAppCheckBox.Name = "templateNewAppCheckBox";
            this.templateNewAppCheckBox.Size = new System.Drawing.Size(64, 25);
            this.templateNewAppCheckBox.TabIndex = 14;
            this.templateNewAppCheckBox.Text = "_APP";
            this.templateNewAppCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateNewGndCheckBox
            // 
            this.templateNewGndCheckBox.AutoSize = true;
            this.templateNewGndCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewGndCheckBox.Location = new System.Drawing.Point(276, 78);
            this.templateNewGndCheckBox.Name = "templateNewGndCheckBox";
            this.templateNewGndCheckBox.Size = new System.Drawing.Size(70, 25);
            this.templateNewGndCheckBox.TabIndex = 13;
            this.templateNewGndCheckBox.Text = "_GND";
            this.templateNewGndCheckBox.UseVisualStyleBackColor = true;
            // 
            // templateNewDelCheckBox
            // 
            this.templateNewDelCheckBox.AutoSize = true;
            this.templateNewDelCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateNewDelCheckBox.Location = new System.Drawing.Point(199, 79);
            this.templateNewDelCheckBox.Name = "templateNewDelCheckBox";
            this.templateNewDelCheckBox.Size = new System.Drawing.Size(63, 25);
            this.templateNewDelCheckBox.TabIndex = 12;
            this.templateNewDelCheckBox.Text = "_DEL";
            this.templateNewDelCheckBox.UseVisualStyleBackColor = true;
            // 
            // templatesGroupBox
            // 
            this.templatesGroupBox.Controls.Add(this.templatePrefixLabel);
            this.templatesGroupBox.Controls.Add(this.templateNewNotUsedRadioButton);
            this.templatesGroupBox.Controls.Add(this.templateDelCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateNewFssCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateGndCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateNewCtrCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateAppCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateNewDepCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateDepCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateNewAppCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateCtrCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateNewGndCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateFssCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateNewDelCheckBox);
            this.templatesGroupBox.Controls.Add(this.templateNotUsedRadioButton);
            this.templatesGroupBox.Controls.Add(this.templateNewPrefixTextBox);
            this.templatesGroupBox.Location = new System.Drawing.Point(17, 411);
            this.templatesGroupBox.Name = "templatesGroupBox";
            this.templatesGroupBox.Size = new System.Drawing.Size(859, 117);
            this.templatesGroupBox.TabIndex = 19;
            this.templatesGroupBox.TabStop = false;
            this.templatesGroupBox.Text = "Templates - Won\'t be seen or used! ";
            this.templatesGroupBox.Visible = false;
            // 
            // instructionButton
            // 
            this.instructionButton.BackColor = System.Drawing.Color.DimGray;
            this.instructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.instructionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionButton.Location = new System.Drawing.Point(17, 346);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(103, 30);
            this.instructionButton.TabIndex = 20;
            this.instructionButton.Text = "Instructions";
            this.instructionButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DimGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(126, 346);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 30);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DimGray;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(773, 346);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 30);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // checkAllButton
            // 
            this.checkAllButton.BackColor = System.Drawing.Color.DimGray;
            this.checkAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllButton.Location = new System.Drawing.Point(551, 346);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(103, 30);
            this.checkAllButton.TabIndex = 23;
            this.checkAllButton.Text = "Check ALL";
            this.checkAllButton.UseVisualStyleBackColor = false;
            // 
            // uncheckAllButton
            // 
            this.uncheckAllButton.BackColor = System.Drawing.Color.DimGray;
            this.uncheckAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uncheckAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uncheckAllButton.Location = new System.Drawing.Point(660, 346);
            this.uncheckAllButton.Name = "uncheckAllButton";
            this.uncheckAllButton.Size = new System.Drawing.Size(107, 30);
            this.uncheckAllButton.TabIndex = 24;
            this.uncheckAllButton.Text = "Uncheck ALL";
            this.uncheckAllButton.UseVisualStyleBackColor = false;
            // 
            // autoPopulateButton
            // 
            this.autoPopulateButton.BackColor = System.Drawing.Color.DimGray;
            this.autoPopulateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoPopulateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoPopulateButton.Location = new System.Drawing.Point(275, 346);
            this.autoPopulateButton.Name = "autoPopulateButton";
            this.autoPopulateButton.Size = new System.Drawing.Size(116, 30);
            this.autoPopulateButton.TabIndex = 25;
            this.autoPopulateButton.Text = "Auto Populate";
            this.autoPopulateButton.UseVisualStyleBackColor = false;
            // 
            // artccComboBox
            // 
            this.artccComboBox.BackColor = System.Drawing.Color.DimGray;
            this.artccComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.artccComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artccComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.artccComboBox.FormattingEnabled = true;
            this.artccComboBox.Location = new System.Drawing.Point(397, 345);
            this.artccComboBox.Name = "artccComboBox";
            this.artccComboBox.Size = new System.Drawing.Size(110, 33);
            this.artccComboBox.TabIndex = 26;
            // 
            // ConfigureArtccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(893, 537);
            this.Controls.Add(this.artccComboBox);
            this.Controls.Add(this.autoPopulateButton);
            this.Controls.Add(this.uncheckAllButton);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.templatesGroupBox);
            this.Controls.Add(this.callsignSuffixlabel);
            this.Controls.Add(this.callsignPrefixLabel);
            this.Controls.Add(this.configurationPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ConfigureArtccForm";
            this.Text = "ConfigureArtccForm";
            this.templatesGroupBox.ResumeLayout(false);
            this.templatesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel configurationPanel;
        private System.Windows.Forms.Label callsignPrefixLabel;
        private System.Windows.Forms.Label callsignSuffixlabel;
        private System.Windows.Forms.Label templatePrefixLabel;
        private System.Windows.Forms.CheckBox templateDelCheckBox;
        private System.Windows.Forms.CheckBox templateGndCheckBox;
        private System.Windows.Forms.CheckBox templateAppCheckBox;
        private System.Windows.Forms.CheckBox templateDepCheckBox;
        private System.Windows.Forms.CheckBox templateCtrCheckBox;
        private System.Windows.Forms.CheckBox templateFssCheckBox;
        private System.Windows.Forms.RadioButton templateNotUsedRadioButton;
        private System.Windows.Forms.TextBox templateNewPrefixTextBox;
        private System.Windows.Forms.RadioButton templateNewNotUsedRadioButton;
        private System.Windows.Forms.CheckBox templateNewFssCheckBox;
        private System.Windows.Forms.CheckBox templateNewCtrCheckBox;
        private System.Windows.Forms.CheckBox templateNewDepCheckBox;
        private System.Windows.Forms.CheckBox templateNewAppCheckBox;
        private System.Windows.Forms.CheckBox templateNewGndCheckBox;
        private System.Windows.Forms.CheckBox templateNewDelCheckBox;
        private System.Windows.Forms.GroupBox templatesGroupBox;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.Button uncheckAllButton;
        private System.Windows.Forms.Button autoPopulateButton;
        private System.Windows.Forms.ComboBox artccComboBox;
    }
}