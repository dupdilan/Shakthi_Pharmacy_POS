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
    public partial class salesInvoice : Form
    {
        int invoice_Id;
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(DBUtil.dbPath);

        public salesInvoice(int passID)
        {
            InitializeComponent();
             invoice_Id = passID;
        }

        private void salesInvoice_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string parent = (Directory.GetParent(Directory.GetParent(path).FullName).FullName).ToString();
            string fullPath = parent + @"\Reports\crystalReport\salesInvoice.rpt";

            cryrpt.Load(@fullPath);
            conn.Open();
            DataSet.item dst = new DataSet.item();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Sales where Invoice_Id="+ invoice_Id, conn);
            sda.Fill(dst, "Sales");
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Sales_Item where Invoice_Id="+ invoice_Id, conn);
            sda1.Fill(dst, "Sales_Item");
            cryrpt.SetDataSource(dst);

            crystalReportViewer1.ReportSource = cryrpt;
            conn.Close();
        }
    }
}
