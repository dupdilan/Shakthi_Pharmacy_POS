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
    public partial class searchInvoive : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");

        public searchInvoive()
        {
            InitializeComponent();
        }

        private void btn_searchInvoice_Click(object sender, EventArgs e)
        {
            int invoice_Id = Convert.ToInt32(txt_invoiceId.Text);
            cryrpt.Load(@"C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\Reports\crystalReport\searchInvoice.rpt");
            conn.Open();
            DataSet.item dst = new DataSet.item();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Sales where Invoice_Id=" + invoice_Id, conn);
            sda.Fill(dst, "Sales");
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Sales_Item where Invoice_Id=" + invoice_Id, conn);
            sda1.Fill(dst, "Sales_Item");
            cryrpt.SetDataSource(dst);

            crystalReportViewer1.ReportSource = cryrpt;
            conn.Close();
        }
    }
}
