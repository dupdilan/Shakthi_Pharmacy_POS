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
    public partial class UserControl_Sales : UserControl
    {
        int zzz;
        private int count = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl_Sales()
        {
            InitializeComponent();
            fillcomboItems();
            fillcomboCustomer();
            setInvoiceId();
            txt_balance.ReadOnly = true;
            txt_noofitems.ReadOnly = true;
            textBox1.ReadOnly = true;
            txt_itemname.ReadOnly = true;
            txt_Customename.ReadOnly = true;
            txt_total.ReadOnly = true;
            txt_net.ReadOnly = true;
            txt_subtotal.ReadOnly = true;
            txt_stock.ReadOnly = true;
           
        }

        private void UserControl_Sales_Load(object sender, EventArgs e)
        {

        }
        void setInvoiceId()
        {
            try
            {
                String sqlquary = "select MAX(Invoice_Id) from Sales";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    String inId = sdr.GetInt32(0).ToString();
                    textBox1.Text = inId;
                }
                conn.Close();
            }
            catch (Exception e005)
            {
                MessageBox.Show(e005.Message);
                conn.Close();
            }
        }
        void fillcomboItems()
        {
            try
            {
                String sqlquary = "select * from Item_details";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    String na = sdr.GetString(0).ToString();
                    cmb_item.Items.Add(na);
                }
                conn.Close();
            }
            catch(Exception e001)
            {
                MessageBox.Show(e001.Message);
                conn.Close();
            }
        }

        void fillcomboCustomer()
        {
            try
            {
                string sqlquary = "select * from Customer";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    string id = sdr.GetString(0).ToString();
                    cmb_CustomerID.Items.Add(id);
                }
                conn.Close();
            }
            catch(Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }
        }

        private void cmb_CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlquary = "select * from Customer where Customer_ID='" + cmb_CustomerID.Text + "';";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();

                while (sdr.Read())
                {
                    string customer = sdr.GetString(1);
                    txt_Customename.Text = customer;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void cmb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlquary = "select * from Item_details where Item_ID ='" + cmb_item.Text + "';";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    String itemname = sdr.GetString(1);
                    txt_itemname.Text = itemname;
                    String price = sdr.GetDouble(4).ToString();
                    txt_price.Text = price.ToString();
                    String itemStock = sdr.GetInt32(5).ToString();
                    txt_stock.Text = itemStock;

                }
                conn.Close();
            }
            catch(Exception e003)
            {
                MessageBox.Show(e003.Message);
                conn.Close();
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                if (Convert.ToInt32(txt_stock.Text) >= Convert.ToInt32(txt_qty.Text))
                {


                    int val1 = Int32.Parse(txt_price.Text);
                    int val2 = Int32.Parse(txt_qty.Text);
                    int totalVal = val1 * val2;
                    txt_total.Text = totalVal.ToString();

                }
                else
                {
                    MessageBox.Show("Your stock Value is too low to do this order!!! Please do a Purchase Orader");
                }
            }
            
            
        }

        private void btn_additems_Click(object sender, EventArgs e)
        {
           
            //add items to list view
            String[] arrSalesItems = new string[6];

           
            arrSalesItems[0] = txt_itemname.Text;
            arrSalesItems[1] = cmb_item.SelectedItem.ToString();
            arrSalesItems[2] = txt_price.Text;
            arrSalesItems[3] = txt_qty.Text;
            arrSalesItems[4] = txt_total.Text;
            arrSalesItems[5] = textBox1.Text;

            ListViewItem lvi = new ListViewItem(arrSalesItems);
            listViewitems.Items.Add(lvi);

            try
            {

                string sqlquary = "insert into Sales_Item(Invoice_Id,Item_Id,Item_name,Sales_price,Qty,Total) values('" + arrSalesItems[5] + "','" + arrSalesItems[1] + "','" + arrSalesItems[0] + "','" + arrSalesItems[2] + "','" + arrSalesItems[3]+ "','" + arrSalesItems[4] + "'); ";
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
                MessageBox.Show("Ex2"+e002.Message);
                conn.Close();
            }
            //update item quntity 
            try
            {
                
                string sqlquaryUpdate = "Update Item_details SET Qty=Qty-'" + arrSalesItems[3] + "'  WHERE Item_ID='" + arrSalesItems[1] + "'";
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
            txt_subtotal.Text = (Convert.ToInt32(arrSalesItems[4]) + (Convert.ToInt32(txt_subtotal.Text))).ToString();
            txt_itemname.Text = "";
            txt_price.Text = "0";
            txt_qty.Text = "";
            txt_stock.Text = "";
            txt_total.Text = "0";
            cmb_item.ResetText();
            txt_noofitems.Text = (Convert.ToInt32(txt_noofitems.Text) + 1).ToString();
        }
        /*
       void updateQty()
        {
            try
            {

                string sqlquary = "update Item_details set Qty ='"+zzz.ToString()+";";
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
                MessageBox.Show(e002.Message);
                conn.Close();
            }
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {

            if (listViewitems.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listViewitems.Items.Count; i++)
                {
                    if (listViewitems.Items[i].Selected)
                    {
                        // int x = Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[6].Text);
                        // txt_sub.Text = x.ToString();
      
                        try
                        {
                            int invoiceDelete = Convert.ToInt32(textBox1.Text);
                            int itemIddelete=Convert.ToInt32(listViewitems.Items[i].SubItems[1].Text);
                            String quary = "delete from Sales_Item where Item_Id = '" + itemIddelete + "' and Invoice_Id='"+ invoiceDelete + "' ";
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
                        
                        txt_noofitems.Text = (Convert.ToInt32(txt_noofitems.Text) - 1).ToString();
                        int oldTotal = Convert.ToInt32(listViewitems.Items[i].SubItems[4].Text);
                        txt_subtotal.Text = (Convert.ToInt32(txt_subtotal.Text) - oldTotal).ToString();
                        listViewitems.Items[i].Remove();

                    }
                }
            }


                       

        }

        private void listViewitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void placeOrder()
        {
            String[] arrSales = new string[9];


            arrSales[0] = textBox1.Text;
            arrSales[1] = txt_date.Text;
            arrSales[2] = cmb_CustomerID.SelectedItem.ToString();     
            arrSales[3] = txt_noofitems.Text;
            arrSales[4] = txt_subtotal.Text;
            arrSales[5] = txt_discount.Text;
            arrSales[6] = txt_net.Text;
            arrSales[7] = txt_paid.Text;
            arrSales[8] = txt_balance.Text;

            try
            {

                string sqlquary1 = "UPDATE Sales SET Date='" + arrSales[1] + "' ,Customer_Id='" + arrSales[2] + "',No_of_Items='" + arrSales[3] + "',Sub_Total='" + arrSales[4] + "',Discount='" + arrSales[5] + "',Net='" + arrSales[6] + "',Paid='" + arrSales[7] + "',Balance='" + arrSales[8] + "' WHERE Invoice_Id='" + arrSales[0] + "' ";                  
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
            int newId = Convert.ToInt32(textBox1.Text) + 1;
            
            cmb_CustomerID.ResetText();
            cmb_item.ResetText();
            txt_Customename.Text = "";
            txt_itemname.Text = "";
            txt_price.Text = "0";
            txt_qty.Text = "";
            txt_total.Text = "0";
            txt_noofitems.Text = "0";
            txt_subtotal.Text = "0";
            txt_discount.Text = "";
            txt_net.Text = "";
            txt_paid.Text = "";
            txt_balance.Text = "";
            listViewitems.Items.Clear();




            try
            {
                string sqlquary1 = "Insert into Sales(Invoice_Id) values('" + newId + "')  ";
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
            setInvoiceId();

        }
        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to Print the Invoice", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer== DialogResult.Yes)
            {
                placeOrder();
                int passId = Convert.ToInt32(textBox1.Text)-1;
                Reports.salesInvoice salesIn = new Reports.salesInvoice(passId);
                salesIn.Show();
                

            }
            else
            {
                placeOrder();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0) {
                txt_net.Text = (Convert.ToInt32(txt_subtotal.Text) - Convert.ToInt32(txt_discount.Text)).ToString();

            }
            
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt32(txt_paid.Text) - Convert.ToInt32(txt_net.Text)).ToString();
            }
        }
    }
}

