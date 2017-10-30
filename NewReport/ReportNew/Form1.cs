using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;



namespace ReportNew
{
    public partial class Form1 : Form
    {
        public static string VchNo = "";
       // public static int VchNo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   this.crystalReportViewer1.RefreshReport();
  ////          CrystalReport1 report = new CrystalReport1();
  ////          TableLogOnInfo logoninfo = new TableLogOnInfo();
  ////          ConnectionInfo LIF = new ConnectionInfo();

  ////          LIF.ServerName = Application.StartupPath + "\\57F4.accdb";
  ////          LIF.DatabaseName = "";
  ////          LIF.UserID = "";
  ////          LIF.Password = "";
  ////          LIF.IntegratedSecurity = false;

          
  ////          foreach (CrystalDecisions.CrystalReports.Engine.Table table in report.Database.Tables)
  ////          {
  ////              logoninfo = table.LogOnInfo;BB
  ////              table.ApplyLogOnInfo(logoninfo);
  ////          }
  //////          report.SetDatabaseLogon("","");
  ////          report.SetParameterValue("VchNo", strVchNo);
  ////          crystalReportViewer1.ReportSource = report;
  //          crystalReportViewer1.ReuseParameterValuesOnRefresh = false;
//            Form1.VchNo = "19";
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            TableLogOnInfo logoninfo = new TableLogOnInfo();
            ConnectionInfo LIF = new ConnectionInfo();

            LIF.ServerName = Application.StartupPath + "\\57F4.accdb";
            LIF.DatabaseName = "";
            LIF.UserID = "";
            LIF.Password = "";
            LIF.IntegratedSecurity = false;


            foreach (CrystalDecisions.CrystalReports.Engine.Table table in report.Database.Tables)
            {
                logoninfo = table.LogOnInfo;
                logoninfo.ConnectionInfo = LIF;

                table.ApplyLogOnInfo(logoninfo);
            }
            //          report.SetDatabaseLogon("","");
            report.SetParameterValue("VchNo", VchNo);
            crystalReportViewer1.ReportSource = report;
        }

        private void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            
        }
    }
}
