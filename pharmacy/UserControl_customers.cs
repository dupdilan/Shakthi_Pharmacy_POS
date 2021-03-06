﻿using System;
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
    public partial class userControl_customers : UserControl
    {
        SqlConnection conn = new SqlConnection(DBUtil.dbPath);
        public userControl_customers()
        {
            InitializeComponent();
            disp_data();
        }
        public void disp_data()
        {

            String quary = "select * from Customer ;";
            SqlCommand com = new SqlCommand(quary, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = com;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataCustomer.DataSource = dt;


        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_customerID.Text != "" && this.txt_customername.Text != "" && this.txt_phone.Text != "" && this.txt_NIC.Text != "" && this.txt_address.Text != "")
                {
                    string sqlquary = "insert into Customer(Customer_ID,Customer_Name,Address,Phone,NIC) values('" + this.txt_customerID.Text + "','" + this.txt_customername.Text + "','" + this.txt_address.Text + "','" + this.txt_phone.Text + "','" + this.txt_NIC.Text + "'); ";
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
                    txt_customerID.Text = " ";
                    txt_customername.Text = " ";
                    txt_address.Text = " ";
                    txt_phone.Text = " ";
                    txt_NIC.Text = " ";


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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                string sqlquary = "delete from Customer where Customer_ID='" + this.txt_customerID.Text + "';";
                SqlCommand com = new SqlCommand(sqlquary, conn);
                SqlDataReader sdr;
                conn.Open();

                sdr = com.ExecuteReader();
                MessageBox.Show("Delete Data");

                while (sdr.Read())
                {

                }

                conn.Close();
                disp_data();
                txt_customerID.Text = " ";
                txt_customername.Text = " ";
                txt_address.Text = " ";
                txt_phone.Text = " ";
                txt_NIC.Text = " ";


            }
            catch (Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }
        }

        private void dataCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_customerID.Text = dataCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txt_customername.Text = dataCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txt_address.Text = dataCustomer.SelectedRows[0].Cells[2].Value.ToString();
            txt_phone.Text = dataCustomer.SelectedRows[0].Cells[3].Value.ToString();
            txt_NIC.Text = dataCustomer.SelectedRows[0].Cells[4].Value.ToString();
          

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlquary = "update Customer set Customer_Name='" + txt_customername.Text+"',Address = '"+txt_address.Text+"',Phone ='"+txt_phone.Text+"',NIC ='"+txt_NIC.Text+ "' WHERE Customer_ID ='" + txt_customerID.Text + "' ;";
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
                txt_customerID.Text = " ";
                txt_customername.Text = " ";
                txt_address.Text = " ";
                txt_phone.Text = " ";
                txt_NIC.Text = " ";


            }
            catch (Exception e002)
            {
                MessageBox.Show(e002.Message);
                conn.Close();
            }
        }

        private void userControl_customers_Load(object sender, EventArgs e)
        {

        }

        private void dataCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_customerID.Text = "";
            txt_customername.Text = "";
            txt_address.Text = "";
            txt_NIC.Text = "";
            txt_phone.Text = "";
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Customer_Search.Text != "")
            {
                String quary = "select * from Customer where Customer_Name='" + this.txt_Customer_Search.Text + "' ;";
                SqlCommand com = new SqlCommand(quary, conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = com;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataCustomer.DataSource = dt;
            }
            else
            {
                disp_data();
            }
        }

        private void txt_Customer_Search_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapt;
            adapt = new SqlDataAdapter("select * from Customer where Customer_Name like '" + txt_Customer_Search.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataCustomer.DataSource = dt;
            conn.Close();
        }
    }
    }

