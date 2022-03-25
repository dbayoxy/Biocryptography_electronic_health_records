namespace BiocryptographyPhD
{
    partial class frmDoctorTask
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
            this.tcTasks = new System.Windows.Forms.TabControl();
            this.tpBasicEHR = new System.Windows.Forms.TabPage();
            this.txtBasicEHR = new System.Windows.Forms.TextBox();
            this.tpConfidentialEHR = new System.Windows.Forms.TabPage();
            this.tpEmergencyEHR = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbLoginDoctor = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFoundPatientName = new System.Windows.Forms.Label();
            this.pbFoundPatient = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tcTasks.SuspendLayout();
            this.tpBasicEHR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginDoctor)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoundPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTasks
            // 
            this.tcTasks.Controls.Add(this.tpBasicEHR);
            this.tcTasks.Controls.Add(this.tpConfidentialEHR);
            this.tcTasks.Controls.Add(this.tpEmergencyEHR);
            this.tcTasks.Location = new System.Drawing.Point(29, 159);
            this.tcTasks.Name = "tcTasks";
            this.tcTasks.SelectedIndex = 0;
            this.tcTasks.Size = new System.Drawing.Size(818, 571);
            this.tcTasks.TabIndex = 0;
            this.tcTasks.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcTasks_Selected);
            // 
            // tpBasicEHR
            // 
            this.tpBasicEHR.BackColor = System.Drawing.Color.White;
            this.tpBasicEHR.Controls.Add(this.txtBasicEHR);
            this.tpBasicEHR.Location = new System.Drawing.Point(4, 22);
            this.tpBasicEHR.Name = "tpBasicEHR";
            this.tpBasicEHR.Padding = new System.Windows.Forms.Padding(3);
            this.tpBasicEHR.Size = new System.Drawing.Size(810, 545);
            this.tpBasicEHR.TabIndex = 0;
            this.tpBasicEHR.Text = "Basic EHR";
            // 
            // txtBasicEHR
            // 
            this.txtBasicEHR.Location = new System.Drawing.Point(3, 3);
            this.txtBasicEHR.Multiline = true;
            this.txtBasicEHR.Name = "txtBasicEHR";
            this.txtBasicEHR.Size = new System.Drawing.Size(688, 519);
            this.txtBasicEHR.TabIndex = 0;
            // 
            // tpConfidentialEHR
            // 
            this.tpConfidentialEHR.Location = new System.Drawing.Point(4, 22);
            this.tpConfidentialEHR.Name = "tpConfidentialEHR";
            this.tpConfidentialEHR.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfidentialEHR.Size = new System.Drawing.Size(810, 545);
            this.tpConfidentialEHR.TabIndex = 1;
            this.tpConfidentialEHR.Text = "Confidential EHR";
            this.tpConfidentialEHR.UseVisualStyleBackColor = true;
            // 
            // tpEmergencyEHR
            // 
            this.tpEmergencyEHR.Location = new System.Drawing.Point(4, 22);
            this.tpEmergencyEHR.Name = "tpEmergencyEHR";
            this.tpEmergencyEHR.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmergencyEHR.Size = new System.Drawing.Size(810, 545);
            this.tpEmergencyEHR.TabIndex = 2;
            this.tpEmergencyEHR.Text = "Emergency EHR";
            this.tpEmergencyEHR.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblWelcome);
            this.groupBox1.Controls.Add(this.pbLoginDoctor);
            this.groupBox1.Location = new System.Drawing.Point(554, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Infomation";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(81, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "label1";
            // 
            // pbLoginDoctor
            // 
            this.pbLoginDoctor.Location = new System.Drawing.Point(25, 19);
            this.pbLoginDoctor.Name = "pbLoginDoctor";
            this.pbLoginDoctor.Size = new System.Drawing.Size(38, 33);
            this.pbLoginDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginDoctor.TabIndex = 0;
            this.pbLoginDoctor.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.txtSearchPatient);
            this.groupBox3.Controls.Add(this.btnSearchPatient);
            this.groupBox3.Location = new System.Drawing.Point(561, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 68);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter patient number";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(46, 34);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(100, 20);
            this.txtSearchPatient.TabIndex = 6;
            this.txtSearchPatient.Text = "PAT\\00A3";
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(152, 31);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatient.TabIndex = 0;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lblFoundPatientName);
            this.groupBox2.Controls.Add(this.pbFoundPatient);
            this.groupBox2.Location = new System.Drawing.Point(29, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Infomation";
            // 
            // lblFoundPatientName
            // 
            this.lblFoundPatientName.AutoSize = true;
            this.lblFoundPatientName.Location = new System.Drawing.Point(87, 31);
            this.lblFoundPatientName.Name = "lblFoundPatientName";
            this.lblFoundPatientName.Size = new System.Drawing.Size(35, 13);
            this.lblFoundPatientName.TabIndex = 2;
            this.lblFoundPatientName.Text = "label1";
            // 
            // pbFoundPatient
            // 
            this.pbFoundPatient.Location = new System.Drawing.Point(25, 19);
            this.pbFoundPatient.Name = "pbFoundPatient";
            this.pbFoundPatient.Size = new System.Drawing.Size(38, 33);
            this.pbFoundPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoundPatient.TabIndex = 1;
            this.pbFoundPatient.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "e-HOSPITAL001 Secure EHR";
            // 
            // frmDoctorTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 742);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tcTasks);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDoctorTask";
            this.Opacity = 0.99;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoctorTask";
            this.Load += new System.EventHandler(this.frmDoctorTask_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoctorTask_FormClosed);
            this.tcTasks.ResumeLayout(false);
            this.tpBasicEHR.ResumeLayout(false);
            this.tpBasicEHR.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginDoctor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoundPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcTasks;
        private System.Windows.Forms.TabPage tpBasicEHR;
        private System.Windows.Forms.TabPage tpConfidentialEHR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tpEmergencyEHR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbLoginDoctor;
        private System.Windows.Forms.PictureBox pbFoundPatient;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFoundPatientName;
        private System.Windows.Forms.TextBox txtBasicEHR;

    }
}