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
        SqlConnection conn = new SqlConnection(DBUtil.dbPath);
        public UserControl_purchase()
        {
            
            InitializeComponent();
            fillcomboItems();
            fillcomboSuppliers();
            setPurchaseId();
            txt_balance.ReadOnly = true;
            txt_noofItems.ReadOnly = true;
            txt_purchaseID.ReadOnly = true;
            txt_itemName.ReadOnly = true;
            txt_sppliername.ReadOnly = true;
            txt_total.ReadOnly = true;
            txt_net.ReadOnly = true;
            txt_Subtotal.ReadOnly = true;
            txt_stock.ReadOnly = true;
        }

        void setPurchaseId()
        {
            try
            {
                String sqlquary = "select MAX(Purchase_Id) from Purchase";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    String inId = sdr.GetInt32(0).ToString();
                    txt_purchaseID.Text = inId;
                }
                conn.Close();
            }
            catch (Exception e005)
            {
                MessageBox.Show(e005.Message);
                conn.Close();
            }
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
                    String itemStock = sdr.GetInt32(5).ToString();
                    txt_stock.Text = itemStock;
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

            //add items to list view
            String[] arrPurchaseItems = new string[6];


            arrPurchaseItems[0] = txt_itemName.Text;
            arrPurchaseItems[1] = cmb_selectemid.SelectedItem.ToString();
            arrPurchaseItems[2] = txt_Price.Text;
            arrPurchaseItems[3] = txt_qty.Text;
            arrPurchaseItems[4] = txt_total.Text;
            arrPurchaseItems[5] = txt_purchaseID.Text;

            ListViewItem lvi = new ListViewItem(arrPurchaseItems);
            listView_Purchase.Items.Add(lvi);

            try
            {

                string sqlquary = "insert into Purchase_Item(Purchase_Id,Item_Id,Item_Name,Cost_Price,Qty,Total) values('" + arrPurchaseItems[5] + "','" + arrPurchaseItems[1] + "','" + arrPurchaseItems[0] + "','" + arrPurchaseItems[2] + "','" + arrPurchaseItems[3] + "','" + arrPurchaseItems[4] + "'); ";
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
                MessageBox.Show("Ex2" + e002.Message);
                conn.Close();
            }
            //update item quntity 
            try
            {

                string sqlquaryUpdate = "Update Item_details SET Qty=Qty+'" + arrPurchaseItems[3] + "'  WHERE Item_ID='" + arrPurchaseItems[1] + "'";
                SqlCommand comUpdate = new SqlCommand(sqlquaryUpdate, conn);
                SqlDataReader sdrUpdate;
                conn.Open();

                sdrUpdate = comUpdate.ExecuteReader();


                while (sdrUpdate.Read())
                {

                }

                conn.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Ex2" + e2.Message);
                conn.Close();
            }
            txt_Subtotal.Text = (Convert.ToInt32(arrPurchaseItems[4]) + (Convert.ToInt32(txt_Subtotal.Text))).ToString();
            txt_itemName.Text = "";
            txt_Price.Text = "0";
            txt_qty.Text = "";
            txt_stock.Text = "";
            txt_total.Text = "0";
            cmb_selectemid.ResetText();
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

                        try
                        {
                            int invoiceDelete = Convert.ToInt32(txt_purchaseID.Text);
                            int itemIddelete = Convert.ToInt32(listView_Purchase.Items[i].SubItems[1].Text);
                            String quary = "delete from Sales_Item where Item_Id = '" + itemIddelete + "' and Invoice_Id='" + invoiceDelete + "' ";
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

                        txt_noofItems.Text = (Convert.ToInt32(txt_noofItems.Text) - 1).ToString();
                        int oldTotal = Convert.ToInt32(listView_Purchase.Items[i].SubItems[4].Text);
                        txt_Subtotal.Text = (Convert.ToInt32(txt_Subtotal.Text) - oldTotal).ToString();
                        listView_Purchase.Items[i].Remove();

                    }
                }
            }
        }
        private void placeOrder()
        {
            String[] arrPurchase = new string[9];


            arrPurchase[0] = txt_purchaseID.Text;
            arrPurchase[1] = txt_date.Text;
            arrPurchase[2] = Cmb_selectSupplier.SelectedItem.ToString();
            arrPurchase[3] = txt_noofItems.Text;
            arrPurchase[4] = txt_Subtotal.Text;
            arrPurchase[5] = txt_discount.Text;
            arrPurchase[6] = txt_net.Text;
            arrPurchase[7] = txt_paid.Text;
            arrPurchase[8] = txt_balance.Text;

            try
            {

                string sqlquary1 = "UPDATE Purchase SET Date='" + arrPurchase[1] + "' ,Suppiler_ID='" + arrPurchase[2] + "',No_of_Items='" + arrPurchase[3] + "',Sub_Total='" + arrPurchase[4] + "',Discount='" + arrPurchase[5] + "',Net='" + arrPurchase[6] + "',Paid='" + arrPurchase[7] + "',Balance='" + arrPurchase[8] + "' WHERE Purchase_Id='" + arrPurchase[0] + "' ";
                SqlCommand com1 = new SqlCommand(sqlquary1, conn);
                SqlDataReader sdr1;
                conn.Open();

                sdr1 = com1.ExecuteReader();


                while (sdr1.Read())
                {

                }

                conn.Close();



            }
            catch (Exception e003)
            {
                //Console.WriteLine("Exception");
                MessageBox.Show(e003.Message);
                conn.Close();
            }
            int newId = Convert.ToInt32(txt_purchaseID.Text) + 1;

            Cmb_selectSupplier.ResetText();
            cmb_selectemid.ResetText();
            txt_sppliername.Text = "";
            txt_itemName.Text = "";
            txt_Price.Text = "0";
            txt_qty.Text = "";
            txt_total.Text = "0";
            txt_noofItems.Text = "0";
            txt_Subtotal.Text = "0";
            txt_discount.Text = "";
            txt_net.Text = "";
            txt_paid.Text = "";
            txt_balance.Text = "";
            listView_Purchase.Items.Clear();




            try
            {
                string sqlquary1 = "Insert into Purchase(Purchase_Id) values('" + newId + "')  ";
                SqlCommand com1 = new SqlCommand(sqlquary1, conn);
                SqlDataReader sdr1;
                conn.Open();

                sdr1 = com1.ExecuteReader();


                while (sdr1.Read())
                {

                }

                conn.Close();

            }
            catch (Exception e0003)
            {
                MessageBox.Show(e0003.Message);
                conn.Close();
            }
            setPurchaseId();

        }




        private void btn_purchase_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to Continous the purchase Order", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                placeOrder();
                /*
                int passId = Convert.ToInt32(txt_purchaseID.Text) - 1;
                Reports.salesInvoice salesIn = new Reports.salesInvoice(passId);
                salesIn.Show();
                */
            }
            
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {

                    int val1 = Int32.Parse(txt_Price.Text);
                    int val2 = Int32.Parse(txt_qty.Text);
                    int totalVal = val1 * val2;
                    txt_total.Text = totalVal.ToString();

                }
              


        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt32(txt_Subtotal.Text) - Convert.ToInt32(txt_discount.Text)).ToString();

            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt32(txt_paid.Text) - Convert.ToInt32(txt_net.Text)).ToString();
            }
        }

        private void txt_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
