namespace pharmacy
{
    partial class UserControl_Sales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_selectcustomer = new System.Windows.Forms.Label();
            this.cmb_CustomerID = new System.Windows.Forms.ComboBox();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.listViewitems = new System.Windows.Forms.ListView();
            this.itemname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Customename = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_customername = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_additems = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_net = new System.Windows.Forms.Label();
            this.lbl_paid = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_noofItems = new System.Windows.Forms.Label();
            this.txt_noofitems = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_selectcustomer
            // 
            this.lbl_selectcustomer.AutoSize = true;
            this.lbl_selectcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectcustomer.Location = new System.Drawing.Point(51, 85);
            this.lbl_selectcustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectcustomer.Name = "lbl_selectcustomer";
            this.lbl_selectcustomer.Size = new System.Drawing.Size(148, 24);
            this.lbl_selectcustomer.TabIndex = 0;
            this.lbl_selectcustomer.Text = "Select Customer";
            // 
            // cmb_CustomerID
            // 
            this.cmb_CustomerID.FormattingEnabled = true;
            this.cmb_CustomerID.Location = new System.Drawing.Point(207, 85);
            this.cmb_CustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_CustomerID.Name = "cmb_CustomerID";
            this.cmb_CustomerID.Size = new System.Drawing.Size(97, 24);
            this.cmb_CustomerID.TabIndex = 1;
            this.cmb_CustomerID.SelectedIndexChanged += new System.EventHandler(this.cmb_CustomerID_SelectedIndexChanged);
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemID.Location = new System.Drawing.Point(469, 85);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(124, 24);
            this.lbl_itemID.TabIndex = 2;
            this.lbl_itemID.Text = "Select Item ID";
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(638, 87);
            this.cmb_item.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(160, 24);
            this.cmb_item.TabIndex = 3;
            this.cmb_item.SelectedIndexChanged += new System.EventHandler(this.cmb_item_SelectedIndexChanged);
            // 
            // listViewitems
            // 
            this.listViewitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemname,
            this.ItemID,
            this.price,
            this.qty,
            this.totall});
            this.listViewitems.Location = new System.Drawing.Point(29, 329);
            this.listViewitems.Margin = new System.Windows.Forms.Padding(4);
            this.listViewitems.Name = "listViewitems";
            this.listViewitems.Size = new System.Drawing.Size(1237, 238);
            this.listViewitems.TabIndex = 4;
            this.listViewitems.UseCompatibleStateImageBehavior = false;
            this.listViewitems.View = System.Windows.Forms.View.Details;
            this.listViewitems.SelectedIndexChanged += new System.EventHandler(this.listViewitems_SelectedIndexChanged);
            // 
            // itemname
            // 
            this.itemname.Text = "Item Name";
            this.itemname.Width = 134;
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            this.ItemID.Width = 118;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 117;
            // 
            // qty
            // 
            this.qty.Text = "Qty";
            this.qty.Width = 85;
            // 
            // totall
            // 
            this.totall.Text = "Total";
            this.totall.Width = 103;
            // 
            // txt_Customename
            // 
            this.txt_Customename.Location = new System.Drawing.Point(55, 223);
            this.txt_Customename.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Customename.Name = "txt_Customename";
            this.txt_Customename.Size = new System.Drawing.Size(132, 22);
            this.txt_Customename.TabIndex = 5;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(242, 223);
            this.txt_itemname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(179, 22);
            this.txt_itemname.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(457, 223);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(132, 22);
            this.txt_price.TabIndex = 7;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(965, 223);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(132, 22);
            this.txt_total.TabIndex = 8;
            this.txt_total.Text = "0";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(749, 223);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(132, 22);
            this.txt_qty.TabIndex = 9;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customername.Location = new System.Drawing.Point(51, 166);
            this.lbl_customername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(147, 24);
            this.lbl_customername.TabIndex = 10;
            this.lbl_customername.Text = "Customer Name";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(267, 166);
            this.lbl_itemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(101, 24);
            this.lbl_itemname.TabIndex = 11;
            this.lbl_itemname.Text = "Item Name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(492, 166);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(53, 24);
            this.lbl_price.TabIndex = 12;
            this.lbl_price.Text = "Price";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(793, 166);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(38, 24);
            this.lbl_qty.TabIndex = 13;
            this.lbl_qty.Text = "Qty";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(992, 166);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(51, 24);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "Total";
            // 
            // btn_additems
            // 
            this.btn_additems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_additems.Location = new System.Drawing.Point(1217, 232);
            this.btn_additems.Margin = new System.Windows.Forms.Padding(4);
            this.btn_additems.Name = "btn_additems";
            this.btn_additems.Size = new System.Drawing.Size(182, 38);
            this.btn_additems.TabIndex = 15;
            this.btn_additems.Text = "Add Items";
            this.btn_additems.UseVisualStyleBackColor = true;
            this.btn_additems.Click += new System.EventHandler(this.btn_additems_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1236, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remove Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sales";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1236, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1123, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Invoice ID";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(306, 622);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(90, 24);
            this.lbl_subtotal.TabIndex = 20;
            this.lbl_subtotal.Text = "Sub Total";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(652, 619);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(83, 24);
            this.lbl_Discount.TabIndex = 21;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(905, 710);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(78, 24);
            this.lbl_balance.TabIndex = 22;
            this.lbl_balance.Text = "Balance";
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_net.Location = new System.Drawing.Point(905, 614);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(39, 24);
            this.lbl_net.TabIndex = 23;
            this.lbl_net.Text = "Net";
            // 
            // lbl_paid
            // 
            this.lbl_paid.AutoSize = true;
            this.lbl_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paid.Location = new System.Drawing.Point(905, 665);
            this.lbl_paid.Name = "lbl_paid";
            this.lbl_paid.Size = new System.Drawing.Size(47, 24);
            this.lbl_paid.TabIndex = 24;
            this.lbl_paid.Text = "Paid";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(425, 621);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(139, 22);
            this.txt_subtotal.TabIndex = 25;
            this.txt_subtotal.Text = "0";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(745, 621);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(100, 22);
            this.txt_discount.TabIndex = 26;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(1059, 614);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(121, 22);
            this.txt_net.TabIndex = 27;
            // 
            // txt_paid
            // 
            this.txt_paid.Location = new System.Drawing.Point(1059, 665);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(121, 22);
            this.txt_paid.TabIndex = 28;
            this.txt_paid.TextChanged += new System.EventHandler(this.txt_paid_TextChanged);
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(1059, 710);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(121, 22);
            this.txt_balance.TabIndex = 29;
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeOrder.Location = new System.Drawing.Point(1173, 752);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(190, 54);
            this.btn_placeOrder.TabIndex = 30;
            this.btn_placeOrder.Text = "Place Order";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(191, 773);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(239, 22);
            this.txt_date.TabIndex = 31;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(98, 773);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 24);
            this.lbl_date.TabIndex = 32;
            this.lbl_date.Text = "Date";
            // 
            // lbl_noofItems
            // 
            this.lbl_noofItems.AutoSize = true;
            this.lbl_noofItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noofItems.Location = new System.Drawing.Point(51, 619);
            this.lbl_noofItems.Name = "lbl_noofItems";
            this.lbl_noofItems.Size = new System.Drawing.Size(104, 24);
            this.lbl_noofItems.TabIndex = 33;
            this.lbl_noofItems.Text = "No of Items";
            // 
            // txt_noofitems
            // 
            this.txt_noofitems.Location = new System.Drawing.Point(161, 621);
            this.txt_noofitems.Name = "txt_noofitems";
            this.txt_noofitems.Size = new System.Drawing.Size(100, 22);
            this.txt_noofitems.TabIndex = 34;
            this.txt_noofitems.Text = "0";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(634, 166);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(56, 24);
            this.lbl_stock.TabIndex = 36;
            this.lbl_stock.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(604, 223);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(132, 22);
            this.txt_stock.TabIndex = 35;
            // 
            // UserControl_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_noofitems);
            this.Controls.Add(this.lbl_noofItems);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_placeOrder);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_paid);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.lbl_paid);
            this.Controls.Add(this.lbl_net);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_additems);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_customername);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.txt_Customename);
            this.Controls.Add(this.listViewitems);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.lbl_itemID);
            this.Controls.Add(this.cmb_CustomerID);
            this.Controls.Add(this.lbl_selectcustomer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Sales";
            this.Size = new System.Drawing.Size(1444, 823);
            this.Load += new System.EventHandler(this.UserControl_Sales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectcustomer;
        private System.Windows.Forms.ComboBox cmb_CustomerID;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.ListView listViewitems;
        private System.Windows.Forms.TextBox txt_Customename;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.ColumnHeader itemname;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader totall;
        private System.Windows.Forms.Button btn_additems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_net;
        private System.Windows.Forms.Label lbl_paid;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_noofItems;
        private System.Windows.Forms.TextBox txt_noofitems;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txt_stock;
    }
}
