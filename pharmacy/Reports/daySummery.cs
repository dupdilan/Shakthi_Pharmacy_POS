using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace pharmacy.Reports
{
    public partial class daySummery : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");

        public daySummery()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string fromDate = txt_from.Text;
            string toDate = txt_to.Text;
            //MessageBox.Show(fromDate, toDate);
            cryrpt.Load(@"C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\Reports\crystalReport\daySummery.rpt");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Sales where Date between "+fromDate+"  AND "+ toDate , conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            conn.Close();

        }
    }
}
