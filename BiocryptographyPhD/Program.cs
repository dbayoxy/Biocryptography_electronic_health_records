﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BiocryptographyPhD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

     
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           

           //// Application.Run(new frmLogin());
           Application.Run(new frmDoctorLogin());

            
           // if (frmDoctorLogin.IsLogged==true)
           // //    Application.Exit();
           // //else
           //     Application.Run(new frmDoctorTask());
        }
    }
}
