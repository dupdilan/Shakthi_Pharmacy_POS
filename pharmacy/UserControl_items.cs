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
using Excel = Microsoft.Office.Interop.Excel;

namespace pharmacy
{
    public partial class UserControl_items : UserControl
    {
        SqlConnection  conn = new SqlConnection(DBUtil.dbPath);

        public UserControl_items()
        {
            InitializeComponent();
            disp_data_Items();
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
        public void  disp_data_Items()
        {
            Console.Write("DISP DATA EXECUTED");
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
                if (this.txt_itemID.Text != "" && this.txt_item_name.Text !="" && this.txt_pricecost.Text != "" &&  this.txt_price.Text != "" )
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
                    disp_data_Items();
                    txt_itemID.Text = " ";
                    txt_item_name.Text = " ";
                    txt_description.Text = " ";
                    txt_pricecost.Text = " ";
                    txt_price.Text = " ";

                    txt_qty.Text = " ";


                }
                else
                {
                    MessageBox.Show("You should have to Fill Correctly!!!");
                }

            }
            catch (Exception e002)
            {
                MessageBox.Show("Cannot use same ID for defferent Items Or If you want to Update item details please click the Update Button..Thank you!!!");
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
                disp_data_Items();
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
                disp_data_Items();
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

        public void UserControl_items_Load(object sender, EventArgs e)
        {
            disp_data_Items();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataItems.RowCount - 1; i++)
            {
                for (j = 0; j <= dataItems.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataItems[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("ItemDetailsBackup.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file in documents");

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            /*String searchItemsName = txt_Item_Search.Text;
            Console.WriteLine(searchItemsName);
            if (txt_Item_Search.Text != "")
            {
                //"select * from Staff where SAP_No like '" + txtBoxSearch.Text + "%'",con

                    String quary = "select * from Item_details where Name like ' "+ searchItemsName + "% ' " ;
                SqlCommand com = new SqlCommand(quary, conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = com;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataItems.DataSource = dt;
            }
            else {
                disp_data_Items();
            }
            */
        }

        private void dataItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchItem(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapt;
            adapt = new SqlDataAdapter("select * from Item_details where Name like '" + txt_Item_Search.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataItems.DataSource = dt;
            conn.Close();
        }
    }
}
