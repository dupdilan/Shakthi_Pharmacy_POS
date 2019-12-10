using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace pharmacy.Reports
{
    public partial class customerReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(DBUtil.dbPath);
        public customerReport()
        {
            InitializeComponent();
        }

        private void customerReport_Load(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                string parent = (Directory.GetParent(Directory.GetParent(path).FullName).FullName).ToString();
                string fullPath = parent + @"\Reports\crystalReport\customerReport.rpt";

                cryrpt.Load(@fullPath);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Customer", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cryrpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = cryrpt;
                conn.Close();
            }catch(Exception e01)
            {
                MessageBox.Show(e01.Message);
            }
            


        }
    }
}
