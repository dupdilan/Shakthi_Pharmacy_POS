using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            userControl_items2.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            dashbordimage1.BringToFront();

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            userControl_customers2.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
          userControl_Sales1.BringToFront();
        }

        private void userControl_items2_Load(object sender, EventArgs e)
        {

        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            userControl_purchase1.BringToFront();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            userControl_suppler2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want toExit", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl_reports1.BringToFront();
        }

        private void dashbordimage1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_suppler2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_lowStock_Click(object sender, EventArgs e)
        {
            Reports.lowStock lowStock = new Reports.lowStock();
            lowStock.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void lbl_important_Click(object sender, EventArgs e)
        {

        }

        private void btn_quick_Click(object sender, EventArgs e)
        {

        }

        private void btn_common_items_Click(object sender, EventArgs e)
        {

        }

        private void btn_daysummery_Click(object sender, EventArgs e)
        {

        }

        private void userControl_customers2_Load(object sender, EventArgs e)
        {

        }

        private void userControl_items2_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void userControl_Sales1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_reports1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_purchase1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
