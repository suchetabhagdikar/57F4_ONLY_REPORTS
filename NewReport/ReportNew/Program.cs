using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReportNew
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                //        Form1.Client_name = args[0].ToString();
                Form1.VchNo = args[0].ToString();

 //               Form1.VchNo = Convert.ToInt32(Form1.strVchNo);
                //  Form1.VchNo=args[0].ToI
                // Form1.Client_names = args[2].ToString();
            }
   
  //          Form1.VchNo = Convert.ToInt32(Form1.strVchNo);
 //           Form1.strVchNo = 19";
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
