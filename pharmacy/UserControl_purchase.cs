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
    public partial class UserControl_purchase : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl_purchase()
        {
            
            InitializeComponent();
            fillcomboItems();
            fillcomboSuppliers();

        }
        void fillcomboSuppliers()
        {
            try
            {
                string sqlquarySup = "select * from Supplier_Details";
                SqlCommand comSup = new SqlCommand(sqlquarySup, conn);
                SqlDataReader sdrSup;
                conn.Open();
                sdrSup = comSup.ExecuteReader();
                while (sdrSup.Read())
                {
                    string sup_id = sdrSup.GetString(0).ToString();
                    Cmb_selectSupplier.Items.Add(sup_id);
                }
                conn.Close();
            }
            catch (Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }
        }

        void fillcomboItems()
        {
            try
            {
                string sqlquaryItem = "select * from Item_Details";
                SqlCommand comItem = new SqlCommand(sqlquaryItem, conn);
                SqlDataReader sdrItem;
                conn.Open();
                sdrItem = comItem.ExecuteReader();
                while (sdrItem.Read())
                {
                    string id = sdrItem.GetString(0).ToString();
                    cmb_selectemid.Items.Add(id);
                }
                conn.Close();
            }
            catch (Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }
        }
        private void Cmb_selectSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlquary = "select * from Supplier_Details where Supplier_ID='" + Cmb_selectSupplier.Text + "';";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();

                while (sdr.Read())
                {
                    string supplier = sdr.GetString(1);
                    txt_sppliername.Text = supplier;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void cmb_selectemid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlquary = "select * from Item_details where Item_ID ='" + cmb_selectemid.Text + "';";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    String itemname = sdr.GetString(1);
                    txt_itemName.Text = itemname;
                    String price = sdr.GetDouble(3).ToString();
                    txt_Price.Text = price;
                }
                conn.Close();
            }
            catch (Exception e003)
            {
                //
                MessageBox.Show(e003.Message);
                conn.Close();
            }
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            String[] arrSalesItems = new string[6];


            arrSalesItems[0] = txt_sppliername.Text;
            arrSalesItems[1] = cmb_selectemid.SelectedItem.ToString();
            arrSalesItems[2] =txt_Price.Text;
            arrSalesItems[3] = txt_qty.Text;
            arrSalesItems[4] = txt_total.Text;
            arrSalesItems[5] = txt_purchaseID.Text;

            ListViewItem lvi = new ListViewItem(arrSalesItems);
            listView_Purchase.Items.Add(lvi);

            try
            {

                string sqlquary = "insert into Sales_Item(Purchase_Id,Item_Id,Item_name,Cost_price,Qty,Total) values('" + arrSalesItems[5] + "','" + arrSalesItems[1] + "','" + arrSalesItems[0] + "','" + arrSalesItems[2] + "','" + arrSalesItems[3] + "','" + arrSalesItems[4] + "'); ";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();

                sdr = com.ExecuteReader();


                while (sdr.Read())
                {

                }

                conn.Close();



            }
            catch (Exception e002)
            {
                //Console.WriteLine("Exception");
                MessageBox.Show(e002.Message);
                conn.Close();
            }
            txt_Subtotal.Text = (Convert.ToInt32(arrSalesItems[4]) + Convert.ToInt32(txt_Subtotal.Text)).ToString();
            txt_itemName.Text = "";
            txt_Price.Text = "0";
            txt_qty.Text = "0";
            txt_total.Text = "0";
            txt_noofItems.Text = (Convert.ToInt32(txt_noofItems.Text) + 1).ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (listView_Purchase.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView_Purchase.Items.Count; i++)
                {
                    if (listView_Purchase.Items[i].Selected)
                    {
                        // int x = Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[6].Text);
                        // txt_sub.Text = x.ToString();
                        listView_Purchase.Items[i].Remove();



                        try
                        {
                            String quary = "delete from Purchase_Item where Item_ID = '" + this.listView_Purchase.Items[i].SubItems[1].Text + "' and Item_Name='" + this.listView_Purchase.Items[i].SubItems[3].Text + "' and Qty = '" + this.listView_Purchase.Items[i].SubItems[5].Text + "' and Total ='" + this.listView_Purchase.Items[i].SubItems[6].Text + "';";
                            SqlCommand com = new SqlCommand(quary, conn);
                            SqlDataReader sda;
                            conn.Open();

                            sda = com.ExecuteReader();

                            while (sda.Read())
                            {

                            }

                            conn.Close();




                        }
                        catch (Exception e01)
                        {
                            MessageBox.Show(e01.Message);
                        }
                    }
                }
            }
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {

        }
    }
}
