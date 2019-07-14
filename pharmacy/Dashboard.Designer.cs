namespace pharmacy
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_Items = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_important = new System.Windows.Forms.Label();
            this.btn_quick = new System.Windows.Forms.Button();
            this.btn_lowStock = new System.Windows.Forms.Button();
            this.btn_common_items = new System.Windows.Forms.Button();
            this.btn_daysummery = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userControl_suppler2 = new pharmacy.UserControl_suppler();
            this.userControl_customers2 = new pharmacy.userControl_customers();
            this.userControl_items2 = new pharmacy.UserControl_items();
            this.dashbordimage1 = new pharmacy.dashbordimage();
            this.userControl_Sales1 = new pharmacy.UserControl_Sales();
            this.userControl_reports1 = new pharmacy.UserControl_reports();
            this.userControl_purchase1 = new pharmacy.UserControl_purchase();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Suppliers);
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Controls.Add(this.btn_sales);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.btn_Items);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 1102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(4, 600);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 86);
            this.button2.TabIndex = 7;
            this.button2.Text = "     Reports";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 105);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shakthi Pharmacy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(4, 886);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 111);
            this.button1.TabIndex = 5;
            this.button1.Text = "     Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.FlatAppearance.BorderSize = 0;
            this.btn_Suppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Suppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suppliers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.White;
            this.btn_Suppliers.Image = ((System.Drawing.Image)(resources.GetObject("btn_Suppliers.Image")));
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Suppliers.Location = new System.Drawing.Point(-9, 305);
            this.btn_Suppliers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Size = new System.Drawing.Size(293, 113);
            this.btn_Suppliers.TabIndex = 4;
            this.btn_Suppliers.Text = "     Suppliers";
            this.btn_Suppliers.UseVisualStyleBackColor = true;
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.FlatAppearance.BorderSize = 0;
            this.btn_purchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_purchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchase.Image")));
            this.btn_purchase.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_purchase.Location = new System.Drawing.Point(4, 416);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(280, 93);
            this.btn_purchase.TabIndex = 3;
            this.btn_purchase.Text = "     Purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.FlatAppearance.BorderSize = 0;
            this.btn_sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.Image = ((System.Drawing.Image)(resources.GetObject("btn_sales.Image")));
            this.btn_sales.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sales.Location = new System.Drawing.Point(3, 506);
            this.btn_sales.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(280, 85);
            this.btn_sales.TabIndex = 2;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Customer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Customer.Image")));
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Customer.Location = new System.Drawing.Point(4, 216);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(280, 102);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "     Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(52, 748);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(177, 33);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "Time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // btn_Items
            // 
            this.btn_Items.FlatAppearance.BorderSize = 0;
            this.btn_Items.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Items.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Items.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Items.ForeColor = System.Drawing.Color.White;
            this.btn_Items.Image = ((System.Drawing.Image)(resources.GetObject("btn_Items.Image")));
            this.btn_Items.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Items.Location = new System.Drawing.Point(4, 121);
            this.btn_Items.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Items.Name = "btn_Items";
            this.btn_Items.Size = new System.Drawing.Size(280, 105);
            this.btn_Items.TabIndex = 0;
            this.btn_Items.Text = "Items";
            this.btn_Items.UseVisualStyleBackColor = true;
            this.btn_Items.Click += new System.EventHandler(this.btn_Items_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(52, 794);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(177, 28);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(288, 993);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1654, 109);
            this.label2.TabIndex = 14;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_important
            // 
            this.lbl_important.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.lbl_important.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_important.Location = new System.Drawing.Point(1706, 0);
            this.lbl_important.Name = "lbl_important";
            this.lbl_important.Size = new System.Drawing.Size(236, 993);
            this.lbl_important.TabIndex = 15;
            this.lbl_important.Click += new System.EventHandler(this.lbl_important_Click);
            // 
            // btn_quick
            // 
            this.btn_quick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btn_quick.FlatAppearance.BorderSize = 0;
            this.btn_quick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quick.Location = new System.Drawing.Point(1801, 1);
            this.btn_quick.Name = "btn_quick";
            this.btn_quick.Size = new System.Drawing.Size(261, 83);
            this.btn_quick.TabIndex = 16;
            this.btn_quick.Text = "Quick Links";
            this.btn_quick.UseVisualStyleBackColor = false;
            this.btn_quick.Click += new System.EventHandler(this.btn_quick_Click);
            // 
            // btn_lowStock
            // 
            this.btn_lowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btn_lowStock.FlatAppearance.BorderSize = 0;
            this.btn_lowStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_lowStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_lowStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowStock.ForeColor = System.Drawing.Color.White;
            this.btn_lowStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_lowStock.Image")));
            this.btn_lowStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lowStock.Location = new System.Drawing.Point(1812, 97);
            this.btn_lowStock.Name = "btn_lowStock";
            this.btn_lowStock.Size = new System.Drawing.Size(341, 79);
            this.btn_lowStock.TabIndex = 17;
            this.btn_lowStock.Text = "Low Stock";
            this.btn_lowStock.UseVisualStyleBackColor = false;
            this.btn_lowStock.Click += new System.EventHandler(this.btn_lowStock_Click);
            // 
            // btn_common_items
            // 
            this.btn_common_items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btn_common_items.FlatAppearance.BorderSize = 0;
            this.btn_common_items.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_common_items.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_common_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_common_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_common_items.ForeColor = System.Drawing.Color.White;
            this.btn_common_items.Image = ((System.Drawing.Image)(resources.GetObject("btn_common_items.Image")));
            this.btn_common_items.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_common_items.Location = new System.Drawing.Point(1812, 197);
            this.btn_common_items.Name = "btn_common_items";
            this.btn_common_items.Size = new System.Drawing.Size(341, 81);
            this.btn_common_items.TabIndex = 18;
            this.btn_common_items.Text = "Higher Items";
            this.btn_common_items.UseVisualStyleBackColor = false;
            this.btn_common_items.Click += new System.EventHandler(this.btn_common_items_Click);
            // 
            // btn_daysummery
            // 
            this.btn_daysummery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btn_daysummery.FlatAppearance.BorderSize = 0;
            this.btn_daysummery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_daysummery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_daysummery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daysummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daysummery.ForeColor = System.Drawing.Color.White;
            this.btn_daysummery.Image = ((System.Drawing.Image)(resources.GetObject("btn_daysummery.Image")));
            this.btn_daysummery.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_daysummery.Location = new System.Drawing.Point(1812, 301);
            this.btn_daysummery.Name = "btn_daysummery";
            this.btn_daysummery.Size = new System.Drawing.Size(341, 77);
            this.btn_daysummery.TabIndex = 19;
            this.btn_daysummery.Text = "Day Summery";
            this.btn_daysummery.UseVisualStyleBackColor = false;
            this.btn_daysummery.Click += new System.EventHandler(this.btn_daysummery_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(295, 939);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(490, 144);
            this.button3.TabIndex = 20;
            this.button3.Text = "Shakthi Pharmacy POS System ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 1023);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Version 1.0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1176, 1027);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(781, 38);
            this.label4.TabIndex = 22;
            this.label4.Text = "All Right Reserved @ 2019 Design and Development by IM Student";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1636, 984);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "Contact Us : 071 9955736";
            // 
            // userControl_suppler2
            // 
            this.userControl_suppler2.Location = new System.Drawing.Point(292, 8);
            this.userControl_suppler2.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_suppler2.Name = "userControl_suppler2";
            this.userControl_suppler2.Size = new System.Drawing.Size(1514, 936);
            this.userControl_suppler2.TabIndex = 13;
            this.userControl_suppler2.Load += new System.EventHandler(this.userControl_suppler2_Load);
            // 
            // userControl_customers2
            // 
            this.userControl_customers2.BackColor = System.Drawing.SystemColors.Control;
            this.userControl_customers2.Location = new System.Drawing.Point(292, 8);
            this.userControl_customers2.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_customers2.Name = "userControl_customers2";
            this.userControl_customers2.Size = new System.Drawing.Size(1513, 921);
            this.userControl_customers2.TabIndex = 12;
            this.userControl_customers2.Load += new System.EventHandler(this.userControl_customers2_Load);
            // 
            // userControl_items2
            // 
            this.userControl_items2.Location = new System.Drawing.Point(291, 8);
            this.userControl_items2.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_items2.Name = "userControl_items2";
            this.userControl_items2.Size = new System.Drawing.Size(1518, 933);
            this.userControl_items2.TabIndex = 11;
            this.userControl_items2.Load += new System.EventHandler(this.userControl_items2_Load_1);
            // 
            // dashbordimage1
            // 
            this.dashbordimage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dashbordimage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashbordimage1.Location = new System.Drawing.Point(288, 0);
            this.dashbordimage1.Name = "dashbordimage1";
            this.dashbordimage1.Size = new System.Drawing.Size(1654, 1102);
            this.dashbordimage1.TabIndex = 10;
            this.dashbordimage1.Load += new System.EventHandler(this.dashbordimage1_Load);
            // 
            // userControl_Sales1
            // 
            this.userControl_Sales1.Location = new System.Drawing.Point(291, 8);
            this.userControl_Sales1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Sales1.Name = "userControl_Sales1";
            this.userControl_Sales1.Size = new System.Drawing.Size(1518, 938);
            this.userControl_Sales1.TabIndex = 9;
            this.userControl_Sales1.Load += new System.EventHandler(this.userControl_Sales1_Load);
            // 
            // userControl_reports1
            // 
            this.userControl_reports1.Location = new System.Drawing.Point(291, 8);
            this.userControl_reports1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_reports1.Name = "userControl_reports1";
            this.userControl_reports1.Size = new System.Drawing.Size(1518, 938);
            this.userControl_reports1.TabIndex = 8;
            this.userControl_reports1.Load += new System.EventHandler(this.userControl_reports1_Load);
            // 
            // userControl_purchase1
            // 
            this.userControl_purchase1.Location = new System.Drawing.Point(288, 1);
            this.userControl_purchase1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_purchase1.Name = "userControl_purchase1";
            this.userControl_purchase1.Size = new System.Drawing.Size(1521, 945);
            this.userControl_purchase1.TabIndex = 7;
            this.userControl_purchase1.Load += new System.EventHandler(this.userControl_purchase1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_daysummery);
            this.Controls.Add(this.btn_common_items);
            this.Controls.Add(this.btn_lowStock);
            this.Controls.Add(this.btn_quick);
            this.Controls.Add(this.lbl_important);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControl_suppler2);
            this.Controls.Add(this.userControl_customers2);
            this.Controls.Add(this.userControl_items2);
            this.Controls.Add(this.dashbordimage1);
            this.Controls.Add(this.userControl_Sales1);
            this.Controls.Add(this.userControl_reports1);
            this.Controls.Add(this.userControl_purchase1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Suppliers;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Items;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private userControl_customers userControl_customers1;
        private UserControl_items userControl_items1;
        private UserControl_purchase userControl_purchase1;
        private UserControl_reports userControl_reports1;
        private UserControl_Sales userControl_Sales1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private UserControl_suppler userControl_suppler1;
        private dashbordimage dashbordimage1;
        private UserControl_items userControl_items2;
        private userControl_customers userControl_customers2;
        private UserControl_suppler userControl_suppler2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_important;
        private System.Windows.Forms.Button btn_quick;
        private System.Windows.Forms.Button btn_lowStock;
        private System.Windows.Forms.Button btn_common_items;
        private System.Windows.Forms.Button btn_daysummery;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}