using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace pharmacy.Reports
{
    public partial class itemReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(DBUtil.dbPath);
        public itemReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void itemReport_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string parent = (Directory.GetParent(Directory.GetParent(path).FullName).FullName).ToString();
            string fullPath = parent + @"\Reports\crystalReport\itemReport.rpt";
            //string fullPath = Path.Combine(parent, @"\Reports\crystalReport\itemReport.rpt");
            //string parentFolder = Directory.GetParent(path);
            //Console.WriteLine(fullPath);
            //Console.WriteLine(parent);

            cryrpt.Load(@fullPath);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from item_details", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            conn.Close();


        }
    }
}
