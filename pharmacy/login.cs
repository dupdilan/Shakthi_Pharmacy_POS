﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacy
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUPDILAN\Desktop\pharmacy\pharmacy\PharmacyNew.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want toExit", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try {
                conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from login where Username='" + txt_Username.Text + "' and Password='" + txt_password.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Dashboard db = new Dashboard();
                    db.Show();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                    txt_Username.Text = "";
                    txt_password.Text = "";

                    conn.Close();
                }
            }
            catch(Exception e01)
            {
                MessageBox.Show(e01.Message);
                conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}