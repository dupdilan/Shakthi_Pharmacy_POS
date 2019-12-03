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
    public partial class daySummery : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(DBUtil.dbPath);

        public daySummery()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string parent = (Directory.GetParent(Directory.GetParent(path).FullName).FullName).ToString();
            string fullPath = parent + @"\Reports\crystalReport\daySummery.rpt";

            string fromDate = txt_from.Text.ToString();
            string toDate = txt_to.Text.ToString();
            //MessageBox.Show(fromDate, toDate);
            
            cryrpt.Load(@fullPath);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Sales where Date between '"+ fromDate +"'  AND '"+toDate+"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            conn.Close();
            
        }

        private void daySummery_Load(object sender, EventArgs e)
        {

        }
    }
}
