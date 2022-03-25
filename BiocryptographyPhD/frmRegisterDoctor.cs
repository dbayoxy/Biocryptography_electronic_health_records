using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using SecuGen.FDxSDKPro.Windows;

namespace BiocryptographyPhD
{
    public partial class frmRegisterDoctor : Form
    {
        public frmRegisterDoctor()
        {
            InitializeComponent();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)

                pbDoctorPicture.Image = Image.FromFile(dlg.FileName);
            
            dlg.Dispose();
                     


        }

        //public Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    using (MemoryStream mStream = new MemoryStream(byteArrayIn))
        //    {
        //        return Image.FromStream(mStream);
        //    }
        //}

        //convert image to bytearray
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }


        public Int32 GetLastDoctorID()
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT MAX(DoctorID) FROM tblDoctorBio", cn);

            cn.Open();
            Int32 intLastID = (Int32)cmd.ExecuteScalar();
            cn.Close();

            //MessageBox.Show("Last ID is " + intLastID);
            return intLastID;
        }

        private void btnSaveDoctorData_Click(object sender, EventArgs e)
        {
            String strHospitalID = txtHospitalID.Text.Trim().ToUpper();
            String strLicenseNo = txtLicenseNo.Text.Trim().ToUpper();
            String strFirstName = txtFName.Text.Trim().ToUpper();
            String strLastName = txtLName.Text.Trim().ToUpper();
            String strGender = txtGender.Text.Trim().ToUpper();
            String strDate = dtpDOB.Value.ToString("dd-MM-yyyy");// dtpDOB.Value.ToShortDateString();

            String strUsername = strLicenseNo;
            String strPassword = txtPassword.Text.Trim();

            Int32 intLastDoctorID = GetLastDoctorID();

            if (pbDoctorPicture.Image != null)
            {
                //Insert the file into database
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
               // SqlCommand cmd = new SqlCommand("INSERT INTO tblDoctorBio(LicenseNo, HospitalID,FName,LName,Gender,DoctorPic,DOB)" +
                //    " VALUES(@LicenseNo, @HospitalID,@FName,@LName,@Gender,@DoctorPic,@DOB)", cn);

                SqlCommand cmd1 = new SqlCommand("UPDATE tblDoctorBio" +
                 " SET LicenseNo=@LicenseNo, HospitalID=@HospitalID,Firstname=@FName,Lastname=@LName,Gender=@Gender,DoctorPic=@DoctorPic,DOB=@DOB " +
                 "WHERE (DoctorID=@intLastDoctorID)", cn);

              //command.Text = "UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add";
                
                SqlCommand cmd2 = new SqlCommand("INSERT INTO tblDoctorLogin(LicenseNo, Password)" +
                    " VALUES(@LicenseNo, @Password)", cn);

                

                cmd1.Parameters.Add("LicenseNo", SqlDbType.VarChar).Value = strLicenseNo;
                cmd1.Parameters.Add("HospitalID", SqlDbType.VarChar).Value = strHospitalID;
                cmd1.Parameters.Add("FName", SqlDbType.VarChar).Value = strFirstName;
                cmd1.Parameters.Add("LName", SqlDbType.VarChar).Value = strLastName;
                cmd1.Parameters.Add("Gender", SqlDbType.VarChar).Value = strGender;              
                cmd1.Parameters.Add("DoctorPic", SqlDbType.VarBinary).Value = imgToByteArray(pbDoctorPicture.Image);
                cmd1.Parameters.Add("DOB", SqlDbType.VarChar).Value = strDate;//Convert.ToDateTime(strDate).Date;
                cmd1.Parameters.Add("intLastDoctorID", SqlDbType.Int).Value = intLastDoctorID;




                cmd2.Parameters.Add("LicenseNo", SqlDbType.VarChar).Value = strLicenseNo;
                cmd2.Parameters.Add("Password", SqlDbType.VarChar).Value = strPassword;


                cn.Open();
                
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cn.Close(); 
                MessageBox.Show("Record Creation Successful\n Your Usernam is: "+strLicenseNo +"\n Your Password is: "+strPassword  );
                //end insert
            }
            else
            {
                MessageBox.Show("No Image selected");
            }
        }

        private void btnCaptureFingerprint_Click(object sender, EventArgs e)
        {
    
            //

            //ENROLLMENT

           

            SGFingerPrintManager m_FPM = new SGFingerPrintManager();
            InitDevice(m_FPM);
            Openport(m_FPM);
            int[] intWH = Getdeviceinfo(m_FPM);
            int m_ImageWidth = intWH[0];
            int m_ImageHeight = intWH[1];
            Byte[] byteTemplate = Capturetemplate(m_FPM, m_ImageWidth, m_ImageHeight);

            string TemplateHex = ByteArrayToString(byteTemplate);

           // MessageBox.Show("Length of template is " + TemplateHex.Length);

          //  MessageBox.Show("Length of template is " + TemplateHex.Length);
            //Insert the file into database
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbBiocryptography;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("INSERT INTO tblDoctorBio(DoctorBiometrics) VALUES(@EnrolledTemplate)", cn);

            cmd.Parameters.Add("EnrolledTemplate", SqlDbType.VarBinary).Value = byteTemplate;
                     

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            //
           
            //
            txtFPInstruction.Text = "Extracting Fingerprint Image \n Please Wait...";

            txtFPInstruction.Text = "Fingerprint capture successful!";
           // MessageBox.Show("Fingerprint capture successful");
            //end insert


        }

        // TEMPLATE REQ
        public string ByteArrayToString(byte[] ba)//(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public void InitDevice(SGFingerPrintManager m_FPM)
        {
            //pictureBox1.Image = null;
            //SGFingerPrintManager m_FPM;
            //Initializing SGFingerPrintManager Object if a device is connected 
            //m_FPM = new SGFingerPrintManager();

            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_AUTO;// DEV_FDU02;

            m_FPM.Init(device_name);// find device
            //end
        }

        public void Openport(SGFingerPrintManager m_FPM)
        {
            // open secugen
            Int32 port_addr; // device id
            port_addr = Convert.ToInt32(SGFPMPortAddr.USB_AUTO_DETECT);
            m_FPM.OpenDevice(port_addr);
            //Opening the SecuGen Fingerprint Reader ends

        }

        public int[] Getdeviceinfo(SGFingerPrintManager m_FPM)
        {
            //get device info
            Int32 m_ImageWidth = 0;
            Int32 m_ImageHeight = 0;
            SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
            pInfo = new SGFPMDeviceInfoParam();
            m_FPM.GetDeviceInfo(pInfo);
            // This should be done GetDeviceInfo();
            m_ImageWidth = pInfo.ImageWidth;
            m_ImageHeight = pInfo.ImageHeight;
            //end

            int[] intWidthHeight = new int[] { m_ImageWidth, m_ImageHeight };
            return intWidthHeight;
        }

        public byte[] Capturetemplate(SGFingerPrintManager m_FPM, Int32 m_ImageWidth, Int32 m_ImageHeight)
        {
           
            //capture device image

            Int32 timeout = 10000; //duration of time to capture quality
            Int32 quality = 80;//quality of image for m_FPM.GetImageEx
            Byte[] fp_image = new Byte[m_ImageWidth * m_ImageHeight]; //fp image


            //create template
            Int32 max_template_size = 0;
            m_FPM.GetMaxTemplateSize(ref max_template_size);
            Byte[] m_RegMin1 = new Byte[max_template_size];
            //Byte[] m_RegMin2 = new Byte[max_template_size];


            m_FPM.GetImageEx(fp_image, timeout, this.pbDoctorFingerprint.Handle.ToInt32(), quality);//capture high quality
            m_FPM.SetBrightness(70);

            //create template
            m_FPM.CreateTemplate(fp_image, m_RegMin1);



            //insert Template Information
            SGFPMFingerInfo finger_info = new SGFPMFingerInfo();
            finger_info.FingerNumber = SGFPMFingerPosition.FINGPOS_RT;
            Int32 img_qlty = 0;
            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            finger_info.ImageQuality = (Int16)img_qlty;
            finger_info.ImpressionType = (Int16)SGFPMImpressionType.IMPTYPE_LP;
            finger_info.ViewNumber = 1;
            m_FPM.CreateTemplate(finger_info, fp_image, m_RegMin1);
            // m_FPM.CreateTemplate(finger_info, fp_image, m_RegMin2);
            //end
            //m_FPM.CloseDevice();


            return m_RegMin1;
            //end create template
        }
        //TEMPLATE REQ ENDS


        private void frmRegisterDoctor_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = txtLicenseNo.Text;
        }

        
       

       
              

               
    }
}
