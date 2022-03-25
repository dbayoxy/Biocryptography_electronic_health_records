using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BiocryptographyPhD
{
    public partial class frmDiagnosis : Form
    {
        public frmDiagnosis()
        {
            InitializeComponent();
        }

        private void frmDiagnosis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }


        public void FillTypeCombo(String strTable, String strColumnRead)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT "+strColumnRead+ " FROM " +strTable, cn);

            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    String strReader = reader[strColumnRead].ToString();
                    //cboRegisteredDoctor.Items.Add(reader["LicenseNo"].ToString());
                    cboType.Items.Add(strReader);
                   

                }

            }
            cboType.SelectedIndex = 0;
            cn.Close();
        }

        public void FillConditionsCombo()
        {
            cboConditions.Items.Add("Common medical conditions");
            cboConditions.Items.Add("Psychiatric conditions");
            cboConditions.Items.Add("Statuses information");
            cboConditions.Items.Add("Surgical information");

            cboConditions.SelectedIndex = 0;


        }

        public void LoadLoginDoctorProfile()
        {
            String strLoginLicense = frmDoctorLogin.LoginLicense;
            Byte[] SavedImage = null;


            //
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblDoctorBio WHERE LicenseNo=@LicenseNo", cn);
            cmd.Parameters.Add("LicenseNo", SqlDbType.VarChar).Value = strLoginLicense;
            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    SavedImage = (Byte[])reader["DoctorPic"];
                    String strFName = reader["Firstname"].ToString();
                    String strLName = reader["Lastname"].ToString();
                    String strWelcome = "Welcome Dr " + strFName + " " + strLName;
                    lblWelcome.Text = strWelcome;
                    pbLoginDoctor.Image = byteArrayToImage(SavedImage);
                }

            }
        }



        private void frmDiagnosis_Load(object sender, EventArgs e)
        {
            LoadLoginDoctorProfile();
            FillConditionsCombo();
            //
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            Byte[] SavedImage = null;
            String strPatientNo = txtSearchPatient.Text.Trim();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblPatientCBiodataCD WHERE PatientNo=@PatientNo", cn);
            cmd.Parameters.Add("PatientNo", SqlDbType.VarChar).Value = strPatientNo;
            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();
            //find patient
            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    SavedImage = (Byte[])reader["PatientPic"];
                    String strFName = reader["Firstname"].ToString();
                    String strLName = reader["Lastname"].ToString();

                    String strPatientName = strFName + " " + strLName;

                    lblFoundPatientName.Text = strPatientName;
                    pbFoundPatient.Image = byteArrayToImage(SavedImage);
                    txtSearchPatient.BackColor = Color.PaleGreen;
                }

                cn.Close();
            }
            else
            {
                lblFoundPatientName.Text = null;
                pbFoundPatient.Image = null;
                txtSearchPatient.BackColor = Color.Red;
                cn.Close();
            }
        }

        private void cboConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            const String strCMC="Common medical conditions";
            const String strPC="Psychiatric conditions";
            const String strStatusesC="Statuses information";
            const String strSurgicalC="Surgical information";

            //cboConditions.Items.Add("Psychiatric conditions");
            //cboConditions.Items.Add("Statuses information");
            //cboConditions.Items.Add("Surgical information");

            String strSelectedCondition = Convert.ToString(cboConditions.SelectedItem);


            switch (strSelectedCondition)
            {
            strCMC :


               
            }
            



        }

       
       

        
    }
}
