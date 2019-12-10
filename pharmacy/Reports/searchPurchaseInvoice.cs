using CrystalDecisions.CrystalReports.Engine;
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

namespace pharmacy.Reports
{
    public partial class searchPurchaseInvoice : Form

    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(DBUtil.dbPath);

        public searchPurchaseInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int invoice_Id = Convert.ToInt32(txt_invoiceId.Text);
                string path = Directory.GetCurrentDirectory();
                string parent = (Directory.GetParent(Directory.GetParent(path).FullName).FullName).ToString();
                string fullPath = parent + @"\Reports\crystalReport\searchInvoice.rpt";

                cryrpt.Load(@fullPath);
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
            catch (Exception e01)
            {
                MessageBox.Show("Please check Sales Invoice NO");
                conn.Close();
            }
        }
    }
}
