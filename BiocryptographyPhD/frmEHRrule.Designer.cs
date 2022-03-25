namespace BiocryptographyPhD
{
    partial class frmEHRrule
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
            this.clbAvailableData = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clbPatientData = new System.Windows.Forms.CheckedListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radCSurgicalC = new System.Windows.Forms.RadioButton();
            this.radCStatusesC = new System.Windows.Forms.RadioButton();
            this.radCPsychiatricC = new System.Windows.Forms.RadioButton();
            this.radCMedicalC = new System.Windows.Forms.RadioButton();
            this.radCBiodataC = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNewItemCategory = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbAvailableData
            // 
            this.clbAvailableData.FormattingEnabled = true;
            this.clbAvailableData.HorizontalScrollbar = true;
            this.clbAvailableData.Location = new System.Drawing.Point(20, 29);
            this.clbAvailableData.Name = "clbAvailableData";
            this.clbAvailableData.Size = new System.Drawing.Size(202, 289);
            this.clbAvailableData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(29, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 71);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Image = global::BiocryptographyPhD.Properties.Resources.minus2;
            this.button2.Location = new System.Drawing.Point(23, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::BiocryptographyPhD.Properties.Resources.add;
            this.button1.Location = new System.Drawing.Point(96, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbAvailableData);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(290, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 371);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clbPatientData);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(563, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 371);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patient Record";
            // 
            // clbPatientData
            // 
            this.clbPatientData.FormattingEnabled = true;
            this.clbPatientData.HorizontalScrollbar = true;
            this.clbPatientData.Location = new System.Drawing.Point(20, 29);
            this.clbPatientData.Name = "clbPatientData";
            this.clbPatientData.Size = new System.Drawing.Size(201, 289);
            this.clbPatientData.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Image = global::BiocryptographyPhD.Properties.Resources.minus2;
            this.button7.Location = new System.Drawing.Point(20, 324);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 27);
            this.button7.TabIndex = 4;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radCSurgicalC);
            this.groupBox4.Controls.Add(this.radCStatusesC);
            this.groupBox4.Controls.Add(this.radCPsychiatricC);
            this.groupBox4.Controls.Add(this.radCMedicalC);
            this.groupBox4.Controls.Add(this.radCBiodataC);
            this.groupBox4.Location = new System.Drawing.Point(29, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 371);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Health Conditions";
            // 
            // radCSurgicalC
            // 
            this.radCSurgicalC.AutoSize = true;
            this.radCSurgicalC.Location = new System.Drawing.Point(51, 226);
            this.radCSurgicalC.Name = "radCSurgicalC";
            this.radCSurgicalC.Size = new System.Drawing.Size(63, 17);
            this.radCSurgicalC.TabIndex = 4;
            this.radCSurgicalC.TabStop = true;
            this.radCSurgicalC.Text = "Surgical";
            this.radCSurgicalC.UseVisualStyleBackColor = true;
            this.radCSurgicalC.CheckedChanged += new System.EventHandler(this.radCSurgicalC_CheckedChanged);
            // 
            // radCStatusesC
            // 
            this.radCStatusesC.AutoSize = true;
            this.radCStatusesC.Location = new System.Drawing.Point(51, 189);
            this.radCStatusesC.Name = "radCStatusesC";
            this.radCStatusesC.Size = new System.Drawing.Size(66, 17);
            this.radCStatusesC.TabIndex = 3;
            this.radCStatusesC.TabStop = true;
            this.radCStatusesC.Text = "Statuses";
            this.radCStatusesC.UseVisualStyleBackColor = true;
            this.radCStatusesC.CheckedChanged += new System.EventHandler(this.radCStatusesC_CheckedChanged);
            // 
            // radCPsychiatricC
            // 
            this.radCPsychiatricC.AutoSize = true;
            this.radCPsychiatricC.Location = new System.Drawing.Point(51, 144);
            this.radCPsychiatricC.Name = "radCPsychiatricC";
            this.radCPsychiatricC.Size = new System.Drawing.Size(76, 17);
            this.radCPsychiatricC.TabIndex = 2;
            this.radCPsychiatricC.TabStop = true;
            this.radCPsychiatricC.Text = "Psychiatric";
            this.radCPsychiatricC.UseVisualStyleBackColor = true;
            this.radCPsychiatricC.CheckedChanged += new System.EventHandler(this.radCPsychiatricC_CheckedChanged);
            // 
            // radCMedicalC
            // 
            this.radCMedicalC.AutoSize = true;
            this.radCMedicalC.Location = new System.Drawing.Point(51, 101);
            this.radCMedicalC.Name = "radCMedicalC";
            this.radCMedicalC.Size = new System.Drawing.Size(158, 17);
            this.radCMedicalC.TabIndex = 1;
            this.radCMedicalC.TabStop = true;
            this.radCMedicalC.Text = "Common Medical Conditions";
            this.radCMedicalC.UseVisualStyleBackColor = true;
            this.radCMedicalC.CheckedChanged += new System.EventHandler(this.radCMedicalC_CheckedChanged);
            // 
            // radCBiodataC
            // 
            this.radCBiodataC.AutoSize = true;
            this.radCBiodataC.Location = new System.Drawing.Point(51, 53);
            this.radCBiodataC.Name = "radCBiodataC";
            this.radCBiodataC.Size = new System.Drawing.Size(61, 17);
            this.radCBiodataC.TabIndex = 0;
            this.radCBiodataC.TabStop = true;
            this.radCBiodataC.Text = "Biodata";
            this.radCBiodataC.UseVisualStyleBackColor = true;
            this.radCBiodataC.CheckedChanged += new System.EventHandler(this.radCBiodataC_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cbNewItemCategory);
            this.groupBox5.Location = new System.Drawing.Point(290, 514);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 108);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // cbNewItemCategory
            // 
            this.cbNewItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewItemCategory.FormattingEnabled = true;
            this.cbNewItemCategory.Location = new System.Drawing.Point(96, 23);
            this.cbNewItemCategory.Name = "cbNewItemCategory";
            this.cbNewItemCategory.Size = new System.Drawing.Size(121, 21);
            this.cbNewItemCategory.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New data";
            // 
            // frmEHRrule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 634);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEHRrule";
            this.Text = "frmEHRrule";
            this.Load += new System.EventHandler(this.frmEHRrule_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbAvailableData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox clbPatientData;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radCSurgicalC;
        private System.Windows.Forms.RadioButton radCStatusesC;
        private System.Windows.Forms.RadioButton radCPsychiatricC;
        private System.Windows.Forms.RadioButton radCMedicalC;
        private System.Windows.Forms.RadioButton radCBiodataC;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNewItemCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;

    }
}