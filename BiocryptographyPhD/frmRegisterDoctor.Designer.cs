namespace BiocryptographyPhD
{
    partial class frmRegisterDoctor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFPInstruction = new System.Windows.Forms.Label();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.pbDoctorPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveDoctorData = new System.Windows.Forms.Button();
            this.btnCaptureFingerprint = new System.Windows.Forms.Button();
            this.pbDoctorFingerprint = new System.Windows.Forms.PictureBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctorPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctorFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFPInstruction);
            this.groupBox1.Controls.Add(this.btnUploadPicture);
            this.groupBox1.Controls.Add(this.pbDoctorPicture);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveDoctorData);
            this.groupBox1.Controls.Add(this.btnCaptureFingerprint);
            this.groupBox1.Controls.Add(this.pbDoctorFingerprint);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtLicenseNo);
            this.groupBox1.Controls.Add(this.txtHospitalID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor\'s Profile";
            // 
            // txtFPInstruction
            // 
            this.txtFPInstruction.AutoSize = true;
            this.txtFPInstruction.Location = new System.Drawing.Point(227, 366);
            this.txtFPInstruction.Name = "txtFPInstruction";
            this.txtFPInstruction.Size = new System.Drawing.Size(137, 13);
            this.txtFPInstruction.TabIndex = 34;
            this.txtFPInstruction.Text = "Place finger on the scanner";
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.AutoSize = true;
            this.btnUploadPicture.Location = new System.Drawing.Point(17, 137);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(105, 23);
            this.btnUploadPicture.TabIndex = 33;
            this.btnUploadPicture.Text = "Upload picture";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // pbDoctorPicture
            // 
            this.pbDoctorPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDoctorPicture.Location = new System.Drawing.Point(17, 19);
            this.pbDoctorPicture.Name = "pbDoctorPicture";
            this.pbDoctorPicture.Size = new System.Drawing.Size(105, 112);
            this.pbDoctorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoctorPicture.TabIndex = 32;
            this.pbDoctorPicture.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Location = new System.Drawing.Point(151, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login data";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUsername.Location = new System.Drawing.Point(93, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(238, 176);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 16;
            this.txtGender.Text = "Male";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "License No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hospital ID";
            // 
            // btnSaveDoctorData
            // 
            this.btnSaveDoctorData.Location = new System.Drawing.Point(371, 578);
            this.btnSaveDoctorData.Name = "btnSaveDoctorData";
            this.btnSaveDoctorData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDoctorData.TabIndex = 7;
            this.btnSaveDoctorData.Text = "Save";
            this.btnSaveDoctorData.UseVisualStyleBackColor = true;
            this.btnSaveDoctorData.Click += new System.EventHandler(this.btnSaveDoctorData_Click);
            // 
            // btnCaptureFingerprint
            // 
            this.btnCaptureFingerprint.Location = new System.Drawing.Point(245, 391);
            this.btnCaptureFingerprint.Name = "btnCaptureFingerprint";
            this.btnCaptureFingerprint.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureFingerprint.TabIndex = 6;
            this.btnCaptureFingerprint.Text = "Capture Fingerprint";
            this.btnCaptureFingerprint.UseVisualStyleBackColor = true;
            this.btnCaptureFingerprint.Click += new System.EventHandler(this.btnCaptureFingerprint_Click);
            // 
            // pbDoctorFingerprint
            // 
            this.pbDoctorFingerprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDoctorFingerprint.Location = new System.Drawing.Point(238, 254);
            this.pbDoctorFingerprint.Name = "pbDoctorFingerprint";
            this.pbDoctorFingerprint.Size = new System.Drawing.Size(110, 95);
            this.pbDoctorFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoctorFingerprint.TabIndex = 5;
            this.pbDoctorFingerprint.TabStop = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(238, 212);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(238, 140);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 3;
            this.txtLName.Text = "Omotosho";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(238, 99);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 2;
            this.txtFName.Text = "Adebayo";
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Location = new System.Drawing.Point(238, 59);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(100, 20);
            this.txtLicenseNo.TabIndex = 1;
            this.txtLicenseNo.Text = "HOSP001\\LIC001";
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Enabled = false;
            this.txtHospitalID.Location = new System.Drawing.Point(238, 19);
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(100, 20);
            this.txtHospitalID.TabIndex = 0;
            this.txtHospitalID.Text = "HOSP001";
            // 
            // frmRegisterDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 643);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegisterDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOSPITAL001";
            this.Load += new System.EventHandler(this.frmRegisterDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctorPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctorFingerprint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLicenseNo;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.PictureBox pbDoctorFingerprint;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSaveDoctorData;
        private System.Windows.Forms.Button btnCaptureFingerprint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.PictureBox pbDoctorPicture;
        private System.Windows.Forms.Label txtFPInstruction;
    }
}

