using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacy
{
    public partial class UserControl_suppler : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl_suppler()
        {
         
            InitializeComponent();
            disp_data();
        }

        private void lbl_Date_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_suppler_Load(object sender, EventArgs e)
        {
            //lbl_Date.Visible = false;
        }

        public void disp_data()
        {

            String quary = "select * from Supplier_Details ;";
            SqlCommand com = new SqlCommand(quary, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = com;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_Suppliers.DataSource = dt;


        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlquary = "insert into Supplier_Details(Supplier_ID,Supplier_Name,Address,Phone,NIC) values('" + this.txt_supplierId.Text + "','" + this.txt_suppliername.Text+ "','" + this.txt_Address.Text + "','" + this.txt_supplierPhone.Text+ "','" + this.txt_NIC.Text + "'); ";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();

                sdr = com.ExecuteReader();


                while (sdr.Read())
                {

                }

                conn.Close();
                disp_data();
                txt_supplierId.Text = " ";
                txt_suppliername.Text = " ";
                txt_supplierPhone.Text = " ";
                txt_Supplier_Search.Text = " ";
                txt_NIC.Text = " ";
                txt_Address.Text = " ";


            }
            catch (Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }

        }

        private void dataGridView_Suppliers_MouseDoubleClick(object sender, MouseEventArgs e)
        {



            txt_supplierId.Text = dataGridView_Suppliers.SelectedRows[0].Cells[0].Value.ToString();
            txt_suppliername.Text = dataGridView_Suppliers.SelectedRows[0].Cells[1].Value.ToString();
            txt_Address.Text = dataGridView_Suppliers.SelectedRows[0].Cells[2].Value.ToString();
            txt_supplierPhone.Text = dataGridView_Suppliers.SelectedRows[0].Cells[3].Value.ToString();
           txt_NIC.Text = dataGridView_Suppliers.SelectedRows[0].Cells[4].Value.ToString();
            


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                String quary = "update Supplier_Details set Supplier_Name ='" + this.txt_suppliername.Text + "', Address='" + this.txt_Address.Text + "', Phone='" + this.txt_supplierPhone.Text + "',NIC='" + this.txt_NIC.Text + "' WHERE Supplier_ID='" + this.txt_supplierId.Text + "' ";
                SqlCommand com = new SqlCommand(quary, conn);
                SqlDataReader sda;
                conn.Open();

                sda = com.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (sda.Read())
                {

                }

                conn.Close();
                disp_data();
                txt_supplierId.Text = " ";
                txt_suppliername.Text = " ";
                txt_supplierPhone.Text = " ";
                txt_Supplier_Search.Text = " ";
                txt_NIC.Text = " ";
                txt_Address.Text = " ";

            }
            catch (Exception e01)
            {
                MessageBox.Show(e01.Message);
                conn.Close();
            }



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                String quary = "delete from Supplier_Details where Supplier_ID='" + this.txt_supplierId.Text + "';";
                SqlCommand com = new SqlCommand(quary, conn);
                SqlDataReader sda;
                conn.Open();

                sda = com.ExecuteReader();
                MessageBox.Show("Data deleted");
                while (sda.Read())
                {

                }

                conn.Close();
                disp_data();
                txt_supplierId.Text = " ";
                txt_suppliername.Text = " ";
                txt_supplierPhone.Text = " ";
                txt_Supplier_Search.Text = " ";
                txt_NIC.Text = " ";
                txt_Address.Text = " ";

            }
            catch (Exception e01)
            {
                MessageBox.Show(e01.Message);
                conn.Close();
            }




        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String quary = "select * from Item_details where Item_ID='" + this.txt_Supplier_Search.Text + "' ;";
            SqlCommand com = new SqlCommand(quary, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = com;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_Suppliers.DataSource = dt;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_supplierId.Text = "";
            txt_suppliername.Text = "";
            txt_supplierPhone.Text = "";
            txt_Supplier_Search.Text = "";
            txt_NIC.Text = "";
            txt_Address.Text = "";
        }
    }
}
