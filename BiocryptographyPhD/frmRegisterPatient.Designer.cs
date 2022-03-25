namespace BiocryptographyPhD
{
    partial class frmRegisterPatient
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
            this.btnSavePatientData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFPInstruction = new System.Windows.Forms.Label();
            this.cboRegisteredDoctor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSexuality = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.btnCapturePatientBiometrics = new System.Windows.Forms.Button();
            this.picPatientBiometrics = new System.Windows.Forms.PictureBox();
            this.pbPatientPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientBiometrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSavePatientData
            // 
            this.btnSavePatientData.Location = new System.Drawing.Point(447, 651);
            this.btnSavePatientData.Name = "btnSavePatientData";
            this.btnSavePatientData.Size = new System.Drawing.Size(75, 23);
            this.btnSavePatientData.TabIndex = 0;
            this.btnSavePatientData.Text = "Save";
            this.btnSavePatientData.UseVisualStyleBackColor = true;
            this.btnSavePatientData.Click += new System.EventHandler(this.btnSavePatientData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFPInstruction);
            this.groupBox1.Controls.Add(this.cboRegisteredDoctor);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSexuality);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnUploadPicture);
            this.groupBox1.Controls.Add(this.btnCapturePatientBiometrics);
            this.groupBox1.Controls.Add(this.picPatientBiometrics);
            this.groupBox1.Controls.Add(this.pbPatientPicture);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtParity);
            this.groupBox1.Controls.Add(this.txtMaritalStatus);
            this.groupBox1.Controls.Add(this.txtNationality);
            this.groupBox1.Controls.Add(this.txtReligion);
            this.groupBox1.Controls.Add(this.btnSavePatientData);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.txtHospitalID);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 700);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Biodata";
            // 
            // txtFPInstruction
            // 
            this.txtFPInstruction.AutoSize = true;
            this.txtFPInstruction.Location = new System.Drawing.Point(264, 518);
            this.txtFPInstruction.Name = "txtFPInstruction";
            this.txtFPInstruction.Size = new System.Drawing.Size(137, 13);
            this.txtFPInstruction.TabIndex = 37;
            this.txtFPInstruction.Text = "Place finger on the scanner";
            // 
            // cboRegisteredDoctor
            // 
            this.cboRegisteredDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegisteredDoctor.FormattingEnabled = true;
            this.cboRegisteredDoctor.Location = new System.Drawing.Point(267, 68);
            this.cboRegisteredDoctor.Name = "cboRegisteredDoctor";
            this.cboRegisteredDoctor.Size = new System.Drawing.Size(252, 21);
            this.cboRegisteredDoctor.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Doctor";
            // 
            // txtSexuality
            // 
            this.txtSexuality.Location = new System.Drawing.Point(267, 365);
            this.txtSexuality.Name = "txtSexuality";
            this.txtSexuality.Size = new System.Drawing.Size(121, 20);
            this.txtSexuality.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Sexuality";
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.AutoSize = true;
            this.btnUploadPicture.Location = new System.Drawing.Point(23, 149);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(105, 23);
            this.btnUploadPicture.TabIndex = 31;
            this.btnUploadPicture.Text = "Upload picture";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // btnCapturePatientBiometrics
            // 
            this.btnCapturePatientBiometrics.AutoSize = true;
            this.btnCapturePatientBiometrics.Location = new System.Drawing.Point(283, 534);
            this.btnCapturePatientBiometrics.Name = "btnCapturePatientBiometrics";
            this.btnCapturePatientBiometrics.Size = new System.Drawing.Size(105, 23);
            this.btnCapturePatientBiometrics.TabIndex = 30;
            this.btnCapturePatientBiometrics.Text = "Capture Biometrics";
            this.btnCapturePatientBiometrics.UseVisualStyleBackColor = true;
            this.btnCapturePatientBiometrics.Click += new System.EventHandler(this.btnCapturePatientBiometrics_Click);
            // 
            // picPatientBiometrics
            // 
            this.picPatientBiometrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPatientBiometrics.Location = new System.Drawing.Point(283, 403);
            this.picPatientBiometrics.Name = "picPatientBiometrics";
            this.picPatientBiometrics.Size = new System.Drawing.Size(105, 112);
            this.picPatientBiometrics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPatientBiometrics.TabIndex = 28;
            this.picPatientBiometrics.TabStop = false;
            // 
            // pbPatientPicture
            // 
            this.pbPatientPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPatientPicture.Location = new System.Drawing.Point(23, 31);
            this.pbPatientPicture.Name = "pbPatientPicture";
            this.pbPatientPicture.Size = new System.Drawing.Size(105, 112);
            this.pbPatientPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatientPicture.TabIndex = 27;
            this.pbPatientPicture.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Location = new System.Drawing.Point(192, 574);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Patient No";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(94, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 23;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtParity
            // 
            this.txtParity.Location = new System.Drawing.Point(267, 336);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(121, 20);
            this.txtParity.TabIndex = 22;
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Location = new System.Drawing.Point(267, 303);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(121, 20);
            this.txtMaritalStatus.TabIndex = 21;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(267, 270);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(121, 20);
            this.txtNationality.TabIndex = 20;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(267, 237);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(121, 20);
            this.txtReligion.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Parity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Marital status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nationality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Religion";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(267, 171);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 20);
            this.dtpDOB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lastname";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(267, 204);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(121, 20);
            this.txtGender.TabIndex = 7;
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Enabled = false;
            this.txtHospitalID.Location = new System.Drawing.Point(267, 38);
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(121, 20);
            this.txtHospitalID.TabIndex = 6;
            this.txtHospitalID.Text = "HOSP001";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(267, 105);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(121, 20);
            this.txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(267, 138);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(121, 20);
            this.txtLName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hospital ID";
            // 
            // frmRegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 715);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegisterPatient";
            this.Text = "frmCreatePatient";
            this.Load += new System.EventHandler(this.frmCreatePatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientBiometrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSavePatientData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtParity;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.PictureBox pbPatientPicture;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.Button btnCapturePatientBiometrics;
        private System.Windows.Forms.PictureBox picPatientBiometrics;
        private System.Windows.Forms.TextBox txtSexuality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboRegisteredDoctor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtFPInstruction;
    }
}