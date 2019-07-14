using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class UserControl_reports : UserControl
    {
        public UserControl_reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnItemReport_Click(object sender, EventArgs e)
        {
            Reports.itemReport itemRep = new Reports.itemReport();
            itemRep.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reports.customerReport cusRep = new Reports.customerReport();
            cusRep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports.supplierReport supRep = new Reports.supplierReport();
            supRep.Show();
        }

        private void btn_LowStock_Click(object sender, EventArgs e)
        {
            Reports.lowStock lowStRep = new Reports.lowStock();
            lowStRep.Show();
        }

        private void UserControl_reports_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports.searchInvoive searchIn = new Reports.searchInvoive();
            searchIn.Show();
        }

        private void btn_day_summery_Click(object sender, EventArgs e)
        {
            Reports.daySummery day = new Reports.daySummery();
            day.Show();
        }
    }
}
