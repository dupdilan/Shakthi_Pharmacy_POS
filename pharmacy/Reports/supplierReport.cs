﻿using System;
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
    public partial class supplierReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");

        public supplierReport()
        {
            InitializeComponent();
        }

        private void supplierReport_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\Reports\crystalReport\supplierReport.rpt");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Supplier_Details", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            conn.Close();


        }
    }
}