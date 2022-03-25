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
    public partial class frmDoctorTask : Form
    {
        public frmDoctorTask()
        {
            InitializeComponent();
        }

        private void frmDoctorTask_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmDoctorTask_Load(object sender, EventArgs e)
        {
            //
            tcTasks.SelectedTab = null;
           
            //
        
            String strLoginLicense=frmDoctorLogin.LoginLicense;
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
                    String strFName=reader["Firstname"].ToString();
                    String strLName = reader["Lastname"].ToString();
                    String strWelcome = "Welcome Dr " + strFName + " " + strLName;
                    lblWelcome.Text  = strWelcome;
                    pbLoginDoctor.Image = byteArrayToImage(SavedImage); 
                }
               
            }
            //


        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {

            //deselect all tabs
            tcTasks.SelectedTab = null;

            //clear page
            txtBasicEHR.Clear();

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


           

        public String ExtractBiodataBasic()
        {
            //Basic fields extraction
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblCBiodataC WHERE Basic=@Biodata", cn);
                cmd.Parameters.Add("Biodata", SqlDbType.VarChar).Value = "A";
                cn.Open();


                SqlDataReader reader = cmd.ExecuteReader();
                String strBasicFields = String.Empty;

                if (reader.HasRows)//has row?
                {
                    while (reader.Read())//start reading
                    {
                        //SavedImage = (Byte[])reader["PatientPic"];
                        if (strBasicFields == String.Empty)
                        {
                            strBasicFields += reader["Biodata"].ToString();
                        }
                        else
                        {
                            strBasicFields +=  ","+reader["Biodata"].ToString();
                        }

                    }
                    
                    //MessageBox.Show(strBasicField);
                    
                }
              cn.Close();
            return strBasicFields ;

        }

        //All CBiodataC fields end


        private void tcTasks_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tpBasicEHR)
            {

                String strTableName=String.Empty;
                String strColumnRead=String.Empty;
                String strBCE=String.Empty;

                strTableName = "tblCBiodataC"; strColumnRead = "Biodata"; strBCE = "Basic";
                //extract Basic Biodata
                String strValidFields=ExtractFields(strTableName, strColumnRead, strBCE);
                String[] strColumn = strValidFields.Split(',');


                if (txtSearchPatient.BackColor == Color.PaleGreen)
                {
                    String strPatientNo = txtSearchPatient.Text.Trim().ToUpper();
                    SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
                    SqlCommand cmd = new SqlCommand("SELECT "+strValidFields+" FROM tblPatientCBiodataCD WHERE PatientNo=@PatientNo", cn);
                    cmd.Parameters.Add("PatientNo", SqlDbType.VarChar).Value = strPatientNo;
                    
                    
                    
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    String strFoundData = String.Empty;
                    String strFoundData2 = String.Empty;
                    //strFoundData = txtSearchPatient.Text.Trim().ToUpper();

                    if (reader.HasRows)//has row?
                    {
                        while (reader.Read())//start reading
                        {


                            foreach (String ColumnN in strColumn)
                            {
                                strFoundData = ColumnN;
                                strFoundData += ": " + reader[ColumnN].ToString();
                                strFoundData2 += strFoundData + "\r\n";
                            }



                        }
                        txtBasicEHR.Text = strFoundData2;
                        cn.Close();

                    }
                   
                }
                else
                {
                    txtBasicEHR.Clear();
                    txtBasicEHR.Text = "\r\n No Basic Record Found";
                }

                }

                


                if (e.TabPage == tpConfidentialEHR)
                {
                    MessageBox.Show("2");
                }
                if (e.TabPage == tpEmergencyEHR)
                {
                    MessageBox.Show("3");
                }

            
        }



        public String ExtractFields(String strTableName, String ColumnRead, String strBCE )
        {
            //Basic fields extraction
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT "+ ColumnRead +" FROM "+ strTableName+ " WHERE "+strBCE+"=@Availability", cn);
            cmd.Parameters.Add("Availability", SqlDbType.VarChar).Value = "A";
            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();
            String strFields = String.Empty;

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    //SavedImage = (Byte[])reader["PatientPic"];
                    if (strFields == String.Empty)
                    {
                        strFields += reader[ColumnRead].ToString();
                    }
                    else
                    {
                        strFields += "," + reader[ColumnRead].ToString();
                    }

                }

                //MessageBox.Show(strBasicField);

            }
            cn.Close();
            return strFields;

        }





        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {

        }

       

        
       
    }
}
