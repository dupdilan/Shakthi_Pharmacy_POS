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
    public partial class UserControl_items : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl_items()
        {
            InitializeComponent();
            disp_data();
        }

        private void data_item_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_itemID.Text = dataItems.SelectedRows[0].Cells[0].Value.ToString();
            txt_item_name.Text = dataItems.SelectedRows[0].Cells[1].Value.ToString();
            txt_description.Text = dataItems.SelectedRows[0].Cells[2].Value.ToString();
            txt_pricecost.Text = dataItems.SelectedRows[0].Cells[3].Value.ToString();
            txt_price.Text = dataItems.SelectedRows[0].Cells[4].Value.ToString();
            txt_qty.Text = dataItems.SelectedRows[0].Cells[5].Value.ToString();
        }
        public void disp_data()
        {

            String quary = "select * from Item_details ;";
            SqlCommand com = new SqlCommand(quary, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = com;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataItems.DataSource = dt;


        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlquary = "insert into Item_details(Item_ID,Name,Description,Price_Cost,Sales_Price,Qty) values('" + this.txt_itemID.Text + "','" + this.txt_item_name.Text + "','" + this.txt_description.Text + "','" + this.txt_pricecost.Text + "','" + this.txt_price.Text + "','" + this.txt_qty.Text + "'); ";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();

                sdr = com.ExecuteReader();
                MessageBox.Show("Save Data");

                while (sdr.Read())
                {

                }

                conn.Close();
                disp_data();
                txt_itemID.Text = " ";
                txt_item_name.Text = " ";
                txt_description.Text = " ";
                txt_pricecost.Text = " ";
                txt_price.Text = " ";
                
                txt_qty.Text = " ";


            }
            catch (Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                String quary = "delete from Item_details where Item_ID='" + this.txt_itemID.Text + "';";
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
                txt_itemID.Text = " ";
                txt_item_name.Text = " ";
                txt_description.Text = " ";
                txt_pricecost.Text = " ";
                txt_price.Text = " ";
                
                txt_qty.Text = " ";
            }
            catch (Exception e01)
            {
                MessageBox.Show(e01.Message);
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlquary = "UPDATE Item_details SET Name='" + this.txt_item_name.Text + "', Description='" + this.txt_description.Text + "',Price_Cost='" + this.txt_pricecost.Text + "',Sales_Price='" + this.txt_price.Text + "',Qty='" + this.txt_qty.Text + "' WHERE Item_ID='" + this.txt_itemID.Text + "' ";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();

                sdr = com.ExecuteReader();
                MessageBox.Show("Update Data");

                while (sdr.Read())
                {

                }

                conn.Close();
                disp_data();
                txt_itemID.Text = " ";
                txt_item_name.Text = " ";
                txt_description.Text = " ";
                txt_pricecost.Text = " ";
                txt_price.Text = " ";

                txt_qty.Text = " ";


            }
            catch (Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_itemID.Text = "";
            txt_item_name.Text = "";
            txt_description.Text = "";
            txt_pricecost.Text = "";
            txt_price.Text = "";
            txt_qty.Text = "";
        }
    }
}
