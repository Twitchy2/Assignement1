namespace Sharp_Mail_Order
{
    partial class SharpMailOrder
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.TotalHoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.CykaRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BonusLabel = new System.Windows.Forms.Label();
            this.BonusTextBox = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.TotalHoursLabel = new System.Windows.Forms.RichTextBox();
            this.TotalSalesLabel = new System.Windows.Forms.RichTextBox();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(26, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Employee Name:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(43, 12);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(70, 13);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Employee ID:";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(156, 35);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameTextBox.TabIndex = 4;
            this.EmployeeNameTextBox.Text = "Enter Text...";
            // 
            // TotalHoursWorkedTextBox
            // 
            this.TotalHoursWorkedTextBox.Location = new System.Drawing.Point(156, 61);
            this.TotalHoursWorkedTextBox.Name = "TotalHoursWorkedTextBox";
            this.TotalHoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalHoursWorkedTextBox.TabIndex = 5;
            this.TotalHoursWorkedTextBox.Text = "Enter Text...";
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(156, 98);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalMonthlySalesTextBox.TabIndex = 6;
            this.TotalMonthlySalesTextBox.Text = "Enter Text...";
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(156, 9);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIdTextBox.TabIndex = 7;
            this.EmployeeIdTextBox.Text = "Enter Text...";
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.CykaRadioButton);
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Location = new System.Drawing.Point(309, 12);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(131, 96);
            this.LanguageGroupBox.TabIndex = 10;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Choose Language";
            // 
            // CykaRadioButton
            // 
            this.CykaRadioButton.AutoSize = true;
            this.CykaRadioButton.Location = new System.Drawing.Point(21, 64);
            this.CykaRadioButton.Name = "CykaRadioButton";
            this.CykaRadioButton.Size = new System.Drawing.Size(62, 17);
            this.CykaRadioButton.TabIndex = 2;
            this.CykaRadioButton.TabStop = true;
            this.CykaRadioButton.Text = "Russkiy";
            this.CykaRadioButton.UseVisualStyleBackColor = true;
            this.CykaRadioButton.CheckedChanged += new System.EventHandler(this.CykaRadioButton_CheckedChanged);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(21, 41);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(21, 18);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(6, 168);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(88, 54);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(100, 168);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 54);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(297, 114);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(143, 107);
            this.LogoPictureBox.TabIndex = 13;
            this.LogoPictureBox.TabStop = false;
            // 
            // BonusLabel
            // 
            this.BonusLabel.AutoSize = true;
            this.BonusLabel.Location = new System.Drawing.Point(68, 140);
            this.BonusLabel.Name = "BonusLabel";
            this.BonusLabel.Size = new System.Drawing.Size(69, 13);
            this.BonusLabel.TabIndex = 14;
            this.BonusLabel.Text = "Sales Bonus:";
            // 
            // BonusTextBox
            // 
            this.BonusTextBox.BackColor = System.Drawing.Color.White;
            this.BonusTextBox.Location = new System.Drawing.Point(156, 140);
            this.BonusTextBox.Name = "BonusTextBox";
            this.BonusTextBox.ReadOnly = true;
            this.BonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.BonusTextBox.TabIndex = 15;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(194, 168);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(88, 54);
            this.PrintButton.TabIndex = 16;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // TotalHoursLabel
            // 
            this.TotalHoursLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.TotalHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalHoursLabel.Location = new System.Drawing.Point(12, 64);
            this.TotalHoursLabel.Name = "TotalHoursLabel";
            this.TotalHoursLabel.Size = new System.Drawing.Size(117, 34);
            this.TotalHoursLabel.TabIndex = 17;
            this.TotalHoursLabel.Text = "Total Hours Worked:";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalSalesLabel.Location = new System.Drawing.Point(12, 101);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(117, 36);
            this.TotalSalesLabel.TabIndex = 18;
            this.TotalSalesLabel.Text = "Total Monthly Sales:";
            // 
            // SharpMailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 237);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.TotalHoursLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.BonusTextBox);
            this.Controls.Add(this.BonusLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.TotalHoursWorkedTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "SharpMailOrder";
            this.Text = "Sharp Mail Order";
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox TotalHoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton CykaRadioButton;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label BonusLabel;
        private System.Windows.Forms.TextBox BonusTextBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.RichTextBox TotalHoursLabel;
        private System.Windows.Forms.RichTextBox TotalSalesLabel;
    }
}

