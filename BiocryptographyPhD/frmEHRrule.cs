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
    public partial class frmEHRrule : Form
    {
        public frmEHRrule()
        {
            InitializeComponent();
        }

        private void radCBiodataC_CheckedChanged(object sender, EventArgs e)
        {
            clbAvailableData.Items.Clear();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT Biodata FROM tblCBiodataC", cn);

            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    clbAvailableData.BeginUpdate();
                    String strReader = reader["Biodata"].ToString();// +" " + reader["LName"].ToString() + " " + reader["LicenseNo"].ToString();
                    //cboRegisteredDoctor.Items.Add(reader["LicenseNo"].ToString());
                    clbAvailableData.Items.Add(strReader);
                    clbAvailableData.EndUpdate();
                }

            }
            //cboRegisteredDoctor.SelectedIndex = 0;
            cn.Close();
        }

        private void radCMedicalC_CheckedChanged(object sender, EventArgs e)
        {
            clbAvailableData.Items.Clear();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT CMedicalC FROM tblCMedicalC", cn);

            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    clbAvailableData.BeginUpdate();
                    String strReader = reader["CMedicalC"].ToString();// +" " + reader["LName"].ToString() + " " + reader["LicenseNo"].ToString();
                    //cboRegisteredDoctor.Items.Add(reader["LicenseNo"].ToString());
                    clbAvailableData.Items.Add(strReader);
                    clbAvailableData.EndUpdate();
                }

            }
            //cboRegisteredDoctor.SelectedIndex = 0;
            cn.Close();
        }

        private void radCPsychiatricC_CheckedChanged(object sender, EventArgs e)
        {
            clbAvailableData.Items.Clear();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT PsychiatricMC FROM tblCPsychiatricC", cn);

            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    clbAvailableData.BeginUpdate();
                    String strReader = reader["PsychiatricMC"].ToString();// +" " + reader["LName"].ToString() + " " + reader["LicenseNo"].ToString();
                    //cboRegisteredDoctor.Items.Add(reader["LicenseNo"].ToString());
                    clbAvailableData.Items.Add(strReader);
                    clbAvailableData.EndUpdate();
                }

            }
            //cboRegisteredDoctor.SelectedIndex = 0;
            cn.Close();
        }

        private void radCStatusesC_CheckedChanged(object sender, EventArgs e)
        {
            clbAvailableData.Items.Clear();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT Statuses FROM tblCStatusesC", cn);

            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    clbAvailableData.BeginUpdate();
                    String strReader = reader["Statuses"].ToString();// +" " + reader["LName"].ToString() + " " + reader["LicenseNo"].ToString();
                    //cboRegisteredDoctor.Items.Add(reader["LicenseNo"].ToString());
                    clbAvailableData.Items.Add(strReader);
                    clbAvailableData.EndUpdate();
                }

            }
            //cboRegisteredDoctor.SelectedIndex = 0;
            cn.Close();

        }

        private void radCSurgicalC_CheckedChanged(object sender, EventArgs e)
        {
            clbAvailableData.Items.Clear();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT CSurgicalC FROM tblCSurgicalC", cn);

            cn.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//has row?
            {
                while (reader.Read())//start reading
                {
                    clbAvailableData.BeginUpdate();
                    String strReader = reader["CSurgicalC"].ToString();// +" " + reader["LName"].ToString() + " " + reader["LicenseNo"].ToString();
                    //cboRegisteredDoctor.Items.Add(reader["LicenseNo"].ToString());
                    clbAvailableData.Items.Add(strReader);
                    clbAvailableData.EndUpdate();
                }

            }
            //cboRegisteredDoctor.SelectedIndex = 0;
            cn.Close();
        }

        private void frmEHRrule_Load(object sender, EventArgs e)
        {
            cbNewItemCategory.Items.Add("Basic");
            cbNewItemCategory.Items.Add("Confidential");
            cbNewItemCategory.Items.Add("Emergency");
            cbNewItemCategory.SelectedIndex = 0;
            
        }

        

        
       

       
       
    }
}
