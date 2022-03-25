using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BiocryptographyPhD
{
    public partial class frmDoctorLogin : Form
    {
        public static String LoginLicense;

        public frmDoctorLogin()
        {
            InitializeComponent();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            ///
            bool boolFound = false;
            String strUsername=txtUsername.Text.Trim();
            String strPassword = txtPassword.Text.Trim();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblDoctorLogin", cn);
            
            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    if ((strUsername == reader["LicenseNo"].ToString()) && (strPassword == reader["Password"].ToString()))
                    {
                        boolFound = true;
                        LoginLicense = strUsername;
                        
                        
                       // IsLogged = true;
                        //this.Close();
                        break;
                    }

                }
                
            }
            cn.Close();
            if (boolFound == true)
            {

                if (radAccessEHR.Checked == true)
                {
                    frmDoctorTask form2 = new frmDoctorTask();
                    //form2.FormClosed += new FormClosedEventHandler(frmDoctorTask_FormClosed);
                    form2.Show();
                    this.Hide();


                }
                else 
                {
                    frmDiagnosis form2 = new frmDiagnosis();
                    form2.Show();
                    this.Hide();
                
                }


                ////MessageBox.Show("Login found");
                //frmDoctorTask form2 = new frmDoctorTask();
                ////form2.FormClosed += new FormClosedEventHandler(frmDoctorTask_FormClosed);
                //form2.Show();
                //this.Hide();

                


            }
            else
            {
                  MessageBox.Show("Login not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            ///




        }
    }
}
