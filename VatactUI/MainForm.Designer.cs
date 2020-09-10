namespace VatactUI
{
    partial class MainForm
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
            this.calculateHoursGroupBox = new System.Windows.Forms.GroupBox();
            this.cidSource = new System.Windows.Forms.Label();
            this.txtFileRadioButton = new System.Windows.Forms.RadioButton();
            this.autoFindRadioButton = new System.Windows.Forms.RadioButton();
            this.bothRadioButton = new System.Windows.Forms.RadioButton();
            this.txtFilePathLabel = new System.Windows.Forms.Label();
            this.txtFilePathTextBox = new System.Windows.Forms.TextBox();
            this.reqHoursLabel = new System.Windows.Forms.Label();
            this.reqHoursTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.artccLabel = new System.Windows.Forms.Label();
            this.artccComboBox = new System.Windows.Forms.ComboBox();
            this.configureLinkLabel = new System.Windows.Forms.LinkLabel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.saveGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.viewControllerGroupBox = new System.Windows.Forms.GroupBox();
            this.controllerComboBox = new System.Windows.Forms.ComboBox();
            this.controllerLabel = new System.Windows.Forms.Label();
            this.failedMinReqCheckBox = new System.Windows.Forms.CheckBox();
            this.artccHoursLabel = new System.Windows.Forms.Label();
            this.otherControlHoursLabel = new System.Windows.Forms.Label();
            this.artccCallsignListBox = new System.Windows.Forms.ListBox();
            this.otherCallsignListBox = new System.Windows.Forms.ListBox();
            this.calculateHoursGroupBox.SuspendLayout();
            this.saveGroupBox.SuspendLayout();
            this.viewControllerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateHoursGroupBox
            // 
            this.calculateHoursGroupBox.Controls.Add(this.calculateButton);
            this.calculateHoursGroupBox.Controls.Add(this.configureLinkLabel);
            this.calculateHoursGroupBox.Controls.Add(this.artccComboBox);
            this.calculateHoursGroupBox.Controls.Add(this.artccLabel);
            this.calculateHoursGroupBox.Controls.Add(this.yearTextBox);
            this.calculateHoursGroupBox.Controls.Add(this.yearLabel);
            this.calculateHoursGroupBox.Controls.Add(this.monthTextBox);
            this.calculateHoursGroupBox.Controls.Add(this.monthLabel);
            this.calculateHoursGroupBox.Controls.Add(this.reqHoursTextBox);
            this.calculateHoursGroupBox.Controls.Add(this.reqHoursLabel);
            this.calculateHoursGroupBox.Controls.Add(this.txtFilePathTextBox);
            this.calculateHoursGroupBox.Controls.Add(this.txtFilePathLabel);
            this.calculateHoursGroupBox.Controls.Add(this.bothRadioButton);
            this.calculateHoursGroupBox.Controls.Add(this.autoFindRadioButton);
            this.calculateHoursGroupBox.Controls.Add(this.txtFileRadioButton);
            this.calculateHoursGroupBox.Controls.Add(this.cidSource);
            this.calculateHoursGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateHoursGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calculateHoursGroupBox.Location = new System.Drawing.Point(12, 12);
            this.calculateHoursGroupBox.Name = "calculateHoursGroupBox";
            this.calculateHoursGroupBox.Size = new System.Drawing.Size(396, 264);
            this.calculateHoursGroupBox.TabIndex = 0;
            this.calculateHoursGroupBox.TabStop = false;
            this.calculateHoursGroupBox.Text = "Calculate Hours";
            // 
            // cidSource
            // 
            this.cidSource.AutoSize = true;
            this.cidSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidSource.Location = new System.Drawing.Point(6, 43);
            this.cidSource.Name = "cidSource";
            this.cidSource.Size = new System.Drawing.Size(90, 21);
            this.cidSource.TabIndex = 0;
            this.cidSource.Text = "CID Source:";
            // 
            // txtFileRadioButton
            // 
            this.txtFileRadioButton.AutoSize = true;
            this.txtFileRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileRadioButton.Location = new System.Drawing.Point(102, 41);
            this.txtFileRadioButton.Name = "txtFileRadioButton";
            this.txtFileRadioButton.Size = new System.Drawing.Size(81, 25);
            this.txtFileRadioButton.TabIndex = 1;
            this.txtFileRadioButton.TabStop = true;
            this.txtFileRadioButton.Text = "TXT File";
            this.txtFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoFindRadioButton
            // 
            this.autoFindRadioButton.AutoSize = true;
            this.autoFindRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoFindRadioButton.Location = new System.Drawing.Point(201, 41);
            this.autoFindRadioButton.Name = "autoFindRadioButton";
            this.autoFindRadioButton.Size = new System.Drawing.Size(102, 25);
            this.autoFindRadioButton.TabIndex = 2;
            this.autoFindRadioButton.TabStop = true;
            this.autoFindRadioButton.Text = "Vatsim API";
            this.autoFindRadioButton.UseVisualStyleBackColor = true;
            // 
            // bothRadioButton
            // 
            this.bothRadioButton.AutoSize = true;
            this.bothRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothRadioButton.Location = new System.Drawing.Point(327, 41);
            this.bothRadioButton.Name = "bothRadioButton";
            this.bothRadioButton.Size = new System.Drawing.Size(60, 25);
            this.bothRadioButton.TabIndex = 3;
            this.bothRadioButton.TabStop = true;
            this.bothRadioButton.Text = "Both";
            this.bothRadioButton.UseVisualStyleBackColor = true;
            // 
            // txtFilePathLabel
            // 
            this.txtFilePathLabel.AutoSize = true;
            this.txtFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePathLabel.Location = new System.Drawing.Point(6, 77);
            this.txtFilePathLabel.Name = "txtFilePathLabel";
            this.txtFilePathLabel.Size = new System.Drawing.Size(100, 21);
            this.txtFilePathLabel.TabIndex = 4;
            this.txtFilePathLabel.Text = "TXT File Path:";
            // 
            // txtFilePathTextBox
            // 
            this.txtFilePathTextBox.BackColor = System.Drawing.Color.DimGray;
            this.txtFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePathTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFilePathTextBox.Location = new System.Drawing.Point(112, 74);
            this.txtFilePathTextBox.Name = "txtFilePathTextBox";
            this.txtFilePathTextBox.Size = new System.Drawing.Size(275, 29);
            this.txtFilePathTextBox.TabIndex = 4;
            // 
            // reqHoursLabel
            // 
            this.reqHoursLabel.AutoSize = true;
            this.reqHoursLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqHoursLabel.Location = new System.Drawing.Point(6, 160);
            this.reqHoursLabel.Name = "reqHoursLabel";
            this.reqHoursLabel.Size = new System.Drawing.Size(122, 21);
            this.reqHoursLabel.TabIndex = 6;
            this.reqHoursLabel.Text = "Min Hours (HH):";
            // 
            // reqHoursTextBox
            // 
            this.reqHoursTextBox.BackColor = System.Drawing.Color.DimGray;
            this.reqHoursTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reqHoursTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqHoursTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reqHoursTextBox.Location = new System.Drawing.Point(134, 158);
            this.reqHoursTextBox.Name = "reqHoursTextBox";
            this.reqHoursTextBox.Size = new System.Drawing.Size(44, 29);
            this.reqHoursTextBox.TabIndex = 7;
            // 
            // monthTextBox
            // 
            this.monthTextBox.BackColor = System.Drawing.Color.DimGray;
            this.monthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.monthTextBox.Location = new System.Drawing.Point(134, 116);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(44, 29);
            this.monthTextBox.TabIndex = 5;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(6, 118);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(101, 21);
            this.monthLabel.TabIndex = 8;
            this.monthLabel.Text = "Month (MM):";
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.DimGray;
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yearTextBox.Location = new System.Drawing.Point(293, 116);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(94, 29);
            this.yearTextBox.TabIndex = 6;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(186, 118);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(93, 21);
            this.yearLabel.TabIndex = 10;
            this.yearLabel.Text = "Year (YYYY):";
            // 
            // artccLabel
            // 
            this.artccLabel.AutoSize = true;
            this.artccLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artccLabel.Location = new System.Drawing.Point(212, 225);
            this.artccLabel.Name = "artccLabel";
            this.artccLabel.Size = new System.Drawing.Size(59, 21);
            this.artccLabel.TabIndex = 12;
            this.artccLabel.Text = "ARTCC:";
            // 
            // artccComboBox
            // 
            this.artccComboBox.BackColor = System.Drawing.Color.DimGray;
            this.artccComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.artccComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artccComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.artccComboBox.FormattingEnabled = true;
            this.artccComboBox.Location = new System.Drawing.Point(277, 219);
            this.artccComboBox.Name = "artccComboBox";
            this.artccComboBox.Size = new System.Drawing.Size(110, 33);
            this.artccComboBox.TabIndex = 8;
            // 
            // configureLinkLabel
            // 
            this.configureLinkLabel.AutoSize = true;
            this.configureLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configureLinkLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.configureLinkLabel.LinkColor = System.Drawing.Color.LightGray;
            this.configureLinkLabel.Location = new System.Drawing.Point(212, 191);
            this.configureLinkLabel.Name = "configureLinkLabel";
            this.configureLinkLabel.Size = new System.Drawing.Size(175, 21);
            this.configureLinkLabel.TabIndex = 14;
            this.configureLinkLabel.TabStop = true;
            this.configureLinkLabel.Text = "Configure / New ARTCC";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.DimGray;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(15, 219);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(143, 33);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // saveGroupBox
            // 
            this.saveGroupBox.Controls.Add(this.resetButton);
            this.saveGroupBox.Controls.Add(this.saveButton);
            this.saveGroupBox.Controls.Add(this.saveDirectoryTextBox);
            this.saveGroupBox.Controls.Add(this.saveLabel);
            this.saveGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveGroupBox.Location = new System.Drawing.Point(432, 12);
            this.saveGroupBox.Name = "saveGroupBox";
            this.saveGroupBox.Size = new System.Drawing.Size(396, 118);
            this.saveGroupBox.TabIndex = 1;
            this.saveGroupBox.TabStop = false;
            this.saveGroupBox.Text = "Save Controller Hours";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DimGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(10, 76);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(157, 33);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // saveDirectoryTextBox
            // 
            this.saveDirectoryTextBox.BackColor = System.Drawing.Color.DimGray;
            this.saveDirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveDirectoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDirectoryTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveDirectoryTextBox.Location = new System.Drawing.Point(126, 41);
            this.saveDirectoryTextBox.Name = "saveDirectoryTextBox";
            this.saveDirectoryTextBox.Size = new System.Drawing.Size(261, 29);
            this.saveDirectoryTextBox.TabIndex = 10;
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.Location = new System.Drawing.Point(6, 43);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(114, 21);
            this.saveLabel.TabIndex = 4;
            this.saveLabel.Text = "Save Directory:";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DimGray;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(232, 77);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(155, 33);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // viewControllerGroupBox
            // 
            this.viewControllerGroupBox.Controls.Add(this.failedMinReqCheckBox);
            this.viewControllerGroupBox.Controls.Add(this.controllerComboBox);
            this.viewControllerGroupBox.Controls.Add(this.controllerLabel);
            this.viewControllerGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewControllerGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewControllerGroupBox.Location = new System.Drawing.Point(432, 167);
            this.viewControllerGroupBox.Name = "viewControllerGroupBox";
            this.viewControllerGroupBox.Size = new System.Drawing.Size(396, 109);
            this.viewControllerGroupBox.TabIndex = 2;
            this.viewControllerGroupBox.TabStop = false;
            this.viewControllerGroupBox.Text = "View Controller Hours";
            // 
            // controllerComboBox
            // 
            this.controllerComboBox.BackColor = System.Drawing.Color.DimGray;
            this.controllerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.controllerComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.controllerComboBox.FormattingEnabled = true;
            this.controllerComboBox.Location = new System.Drawing.Point(95, 36);
            this.controllerComboBox.Name = "controllerComboBox";
            this.controllerComboBox.Size = new System.Drawing.Size(292, 33);
            this.controllerComboBox.TabIndex = 13;
            // 
            // controllerLabel
            // 
            this.controllerLabel.AutoSize = true;
            this.controllerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerLabel.Location = new System.Drawing.Point(6, 42);
            this.controllerLabel.Name = "controllerLabel";
            this.controllerLabel.Size = new System.Drawing.Size(83, 21);
            this.controllerLabel.TabIndex = 12;
            this.controllerLabel.Text = "Controller:";
            // 
            // failedMinReqCheckBox
            // 
            this.failedMinReqCheckBox.AutoSize = true;
            this.failedMinReqCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedMinReqCheckBox.Location = new System.Drawing.Point(10, 81);
            this.failedMinReqCheckBox.Name = "failedMinReqCheckBox";
            this.failedMinReqCheckBox.Size = new System.Drawing.Size(239, 25);
            this.failedMinReqCheckBox.TabIndex = 14;
            this.failedMinReqCheckBox.Text = "Failed Hour Requirement Only";
            this.failedMinReqCheckBox.UseVisualStyleBackColor = true;
            // 
            // artccHoursLabel
            // 
            this.artccHoursLabel.AutoSize = true;
            this.artccHoursLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artccHoursLabel.Location = new System.Drawing.Point(7, 308);
            this.artccHoursLabel.Name = "artccHoursLabel";
            this.artccHoursLabel.Size = new System.Drawing.Size(369, 30);
            this.artccHoursLabel.TabIndex = 3;
            this.artccHoursLabel.Text = "{ARTCC} Control Hours {HH:MM:SS}";
            // 
            // otherControlHoursLabel
            // 
            this.otherControlHoursLabel.AutoSize = true;
            this.otherControlHoursLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherControlHoursLabel.Location = new System.Drawing.Point(427, 308);
            this.otherControlHoursLabel.Name = "otherControlHoursLabel";
            this.otherControlHoursLabel.Size = new System.Drawing.Size(344, 30);
            this.otherControlHoursLabel.TabIndex = 4;
            this.otherControlHoursLabel.Text = "Other Control Hours {HH:MM:SS}";
            // 
            // artccCallsignListBox
            // 
            this.artccCallsignListBox.BackColor = System.Drawing.Color.DimGray;
            this.artccCallsignListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artccCallsignListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.artccCallsignListBox.FormattingEnabled = true;
            this.artccCallsignListBox.ItemHeight = 21;
            this.artccCallsignListBox.Location = new System.Drawing.Point(12, 352);
            this.artccCallsignListBox.Name = "artccCallsignListBox";
            this.artccCallsignListBox.Size = new System.Drawing.Size(396, 212);
            this.artccCallsignListBox.TabIndex = 5;
            // 
            // otherCallsignListBox
            // 
            this.otherCallsignListBox.BackColor = System.Drawing.Color.DimGray;
            this.otherCallsignListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherCallsignListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.otherCallsignListBox.FormattingEnabled = true;
            this.otherCallsignListBox.ItemHeight = 21;
            this.otherCallsignListBox.Location = new System.Drawing.Point(432, 352);
            this.otherCallsignListBox.Name = "otherCallsignListBox";
            this.otherCallsignListBox.Size = new System.Drawing.Size(396, 212);
            this.otherCallsignListBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(839, 571);
            this.Controls.Add(this.otherCallsignListBox);
            this.Controls.Add(this.artccCallsignListBox);
            this.Controls.Add(this.otherControlHoursLabel);
            this.Controls.Add(this.artccHoursLabel);
            this.Controls.Add(this.viewControllerGroupBox);
            this.Controls.Add(this.saveGroupBox);
            this.Controls.Add(this.calculateHoursGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "VATACT";
            this.calculateHoursGroupBox.ResumeLayout(false);
            this.calculateHoursGroupBox.PerformLayout();
            this.saveGroupBox.ResumeLayout(false);
            this.saveGroupBox.PerformLayout();
            this.viewControllerGroupBox.ResumeLayout(false);
            this.viewControllerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox calculateHoursGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.LinkLabel configureLinkLabel;
        private System.Windows.Forms.ComboBox artccComboBox;
        private System.Windows.Forms.Label artccLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox reqHoursTextBox;
        private System.Windows.Forms.Label reqHoursLabel;
        private System.Windows.Forms.TextBox txtFilePathTextBox;
        private System.Windows.Forms.Label txtFilePathLabel;
        private System.Windows.Forms.RadioButton bothRadioButton;
        private System.Windows.Forms.RadioButton autoFindRadioButton;
        private System.Windows.Forms.RadioButton txtFileRadioButton;
        private System.Windows.Forms.Label cidSource;
        private System.Windows.Forms.GroupBox saveGroupBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox saveDirectoryTextBox;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.GroupBox viewControllerGroupBox;
        private System.Windows.Forms.CheckBox failedMinReqCheckBox;
        private System.Windows.Forms.ComboBox controllerComboBox;
        private System.Windows.Forms.Label controllerLabel;
        private System.Windows.Forms.Label artccHoursLabel;
        private System.Windows.Forms.Label otherControlHoursLabel;
        private System.Windows.Forms.ListBox artccCallsignListBox;
        private System.Windows.Forms.ListBox otherCallsignListBox;
    }
}

