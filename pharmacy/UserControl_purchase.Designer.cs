namespace pharmacy
{
    partial class UserControl_purchase
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_selectSupplier = new System.Windows.Forms.Label();
            this.lbl_Suppliername = new System.Windows.Forms.Label();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_SelectItemID = new System.Windows.Forms.Label();
            this.lbl_PurchaseID = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_sppliername = new System.Windows.Forms.TextBox();
            this.txt_purchaseID = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.Cmb_selectSupplier = new System.Windows.Forms.ComboBox();
            this.cmb_selectemid = new System.Windows.Forms.ComboBox();
            this.listView_Purchase = new System.Windows.Forms.ListView();
            this.Item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lbl_noofitems = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_paid = new System.Windows.Forms.Label();
            this.lbl_net = new System.Windows.Forms.Label();
            this.txt_noofItems = new System.Windows.Forms.TextBox();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchase";
            // 
            // lbl_selectSupplier
            // 
            this.lbl_selectSupplier.AutoSize = true;
            this.lbl_selectSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectSupplier.Location = new System.Drawing.Point(78, 93);
            this.lbl_selectSupplier.Name = "lbl_selectSupplier";
            this.lbl_selectSupplier.Size = new System.Drawing.Size(137, 24);
            this.lbl_selectSupplier.TabIndex = 2;
            this.lbl_selectSupplier.Text = "Select Supplier";
            // 
            // lbl_Suppliername
            // 
            this.lbl_Suppliername.AutoSize = true;
            this.lbl_Suppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Suppliername.Location = new System.Drawing.Point(83, 178);
            this.lbl_Suppliername.Name = "lbl_Suppliername";
            this.lbl_Suppliername.Size = new System.Drawing.Size(136, 24);
            this.lbl_Suppliername.TabIndex = 3;
            this.lbl_Suppliername.Text = "Supplier Name";
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.Location = new System.Drawing.Point(328, 178);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(101, 24);
            this.lbl_ItemName.TabIndex = 4;
            this.lbl_ItemName.Text = "Item Name";
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qty.Location = new System.Drawing.Point(750, 178);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(38, 24);
            this.lbl_Qty.TabIndex = 5;
            this.lbl_Qty.Text = "Qty";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(495, 178);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(53, 24);
            this.lbl_price.TabIndex = 6;
            this.lbl_price.Text = "Price";
            // 
            // lbl_SelectItemID
            // 
            this.lbl_SelectItemID.AutoSize = true;
            this.lbl_SelectItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectItemID.Location = new System.Drawing.Point(404, 89);
            this.lbl_SelectItemID.Name = "lbl_SelectItemID";
            this.lbl_SelectItemID.Size = new System.Drawing.Size(124, 24);
            this.lbl_SelectItemID.TabIndex = 7;
            this.lbl_SelectItemID.Text = "Select Item ID";
            // 
            // lbl_PurchaseID
            // 
            this.lbl_PurchaseID.AutoSize = true;
            this.lbl_PurchaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchaseID.Location = new System.Drawing.Point(842, 50);
            this.lbl_PurchaseID.Name = "lbl_PurchaseID";
            this.lbl_PurchaseID.Size = new System.Drawing.Size(112, 24);
            this.lbl_PurchaseID.TabIndex = 8;
            this.lbl_PurchaseID.Text = "Purchase ID";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(890, 178);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(51, 24);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "Total";
            // 
            // txt_sppliername
            // 
            this.txt_sppliername.Location = new System.Drawing.Point(86, 223);
            this.txt_sppliername.Name = "txt_sppliername";
            this.txt_sppliername.Size = new System.Drawing.Size(129, 22);
            this.txt_sppliername.TabIndex = 10;
            // 
            // txt_purchaseID
            // 
            this.txt_purchaseID.Location = new System.Drawing.Point(960, 52);
            this.txt_purchaseID.Name = "txt_purchaseID";
            this.txt_purchaseID.Size = new System.Drawing.Size(142, 22);
            this.txt_purchaseID.TabIndex = 11;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(478, 223);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(120, 22);
            this.txt_Price.TabIndex = 12;
            // 
            // txt_itemName
            // 
            this.txt_itemName.Location = new System.Drawing.Point(322, 223);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(122, 22);
            this.txt_itemName.TabIndex = 13;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(742, 223);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(119, 22);
            this.txt_qty.TabIndex = 14;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(883, 223);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 22);
            this.txt_total.TabIndex = 15;
            this.txt_total.Text = "0";
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // Cmb_selectSupplier
            // 
            this.Cmb_selectSupplier.FormattingEnabled = true;
            this.Cmb_selectSupplier.Location = new System.Drawing.Point(221, 91);
            this.Cmb_selectSupplier.Name = "Cmb_selectSupplier";
            this.Cmb_selectSupplier.Size = new System.Drawing.Size(121, 24);
            this.Cmb_selectSupplier.TabIndex = 16;
            this.Cmb_selectSupplier.SelectedIndexChanged += new System.EventHandler(this.Cmb_selectSupplier_SelectedIndexChanged);
            // 
            // cmb_selectemid
            // 
            this.cmb_selectemid.FormattingEnabled = true;
            this.cmb_selectemid.Location = new System.Drawing.Point(534, 89);
            this.cmb_selectemid.Name = "cmb_selectemid";
            this.cmb_selectemid.Size = new System.Drawing.Size(121, 24);
            this.cmb_selectemid.TabIndex = 17;
            this.cmb_selectemid.SelectedIndexChanged += new System.EventHandler(this.cmb_selectemid_SelectedIndexChanged);
            // 
            // listView_Purchase
            // 
            this.listView_Purchase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item_name,
            this.Item_ID,
            this.price,
            this.Qty,
            this.Total});
            this.listView_Purchase.Location = new System.Drawing.Point(94, 331);
            this.listView_Purchase.Name = "listView_Purchase";
            this.listView_Purchase.Size = new System.Drawing.Size(957, 244);
            this.listView_Purchase.TabIndex = 18;
            this.listView_Purchase.UseCompatibleStateImageBehavior = false;
            this.listView_Purchase.View = System.Windows.Forms.View.Details;
            // 
            // Item_name
            // 
            this.Item_name.Text = "Item Name";
            this.Item_name.Width = 241;
            // 
            // Item_ID
            // 
            this.Item_ID.Text = "Item ID";
            this.Item_ID.Width = 202;
            // 
            // price
            // 
            this.price.Text = "price";
            this.price.Width = 198;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 142;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 166;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1056, 212);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(167, 48);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(1067, 266);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(146, 41);
            this.btn_Remove.TabIndex = 20;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // lbl_noofitems
            // 
            this.lbl_noofitems.AutoSize = true;
            this.lbl_noofitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noofitems.Location = new System.Drawing.Point(49, 593);
            this.lbl_noofitems.Name = "lbl_noofitems";
            this.lbl_noofitems.Size = new System.Drawing.Size(104, 24);
            this.lbl_noofitems.TabIndex = 21;
            this.lbl_noofitems.Text = "No of Items";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(318, 593);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(90, 24);
            this.lbl_subtotal.TabIndex = 22;
            this.lbl_subtotal.Text = "Sub Total";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.Location = new System.Drawing.Point(642, 593);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(83, 24);
            this.lbl_discount.TabIndex = 23;
            this.lbl_discount.Text = "Discount";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(947, 704);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(78, 24);
            this.lbl_balance.TabIndex = 24;
            this.lbl_balance.Text = "Balance";
            // 
            // lbl_paid
            // 
            this.lbl_paid.AutoSize = true;
            this.lbl_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paid.Location = new System.Drawing.Point(947, 651);
            this.lbl_paid.Name = "lbl_paid";
            this.lbl_paid.Size = new System.Drawing.Size(47, 24);
            this.lbl_paid.TabIndex = 25;
            this.lbl_paid.Text = "Paid";
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_net.Location = new System.Drawing.Point(947, 590);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(39, 24);
            this.lbl_net.TabIndex = 26;
            this.lbl_net.Text = "Net";
            // 
            // txt_noofItems
            // 
            this.txt_noofItems.Location = new System.Drawing.Point(143, 593);
            this.txt_noofItems.Name = "txt_noofItems";
            this.txt_noofItems.Size = new System.Drawing.Size(100, 22);
            this.txt_noofItems.TabIndex = 27;
            this.txt_noofItems.Text = "0";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Location = new System.Drawing.Point(435, 590);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(100, 22);
            this.txt_Subtotal.TabIndex = 28;
            this.txt_Subtotal.Text = "0";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(728, 590);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(100, 22);
            this.txt_discount.TabIndex = 29;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(1067, 585);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(124, 22);
            this.txt_net.TabIndex = 30;
            // 
            // txt_paid
            // 
            this.txt_paid.Location = new System.Drawing.Point(1067, 646);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(124, 22);
            this.txt_paid.TabIndex = 31;
            this.txt_paid.TextChanged += new System.EventHandler(this.txt_paid_TextChanged);
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(1067, 699);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(124, 22);
            this.txt_balance.TabIndex = 32;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(90, 757);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 24);
            this.lbl_date.TabIndex = 33;
            this.lbl_date.Text = "Date";
            // 
            // txt_date
            // 
            this.txt_date.CustomFormat = "MM/dd/yyyy";
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_date.Location = new System.Drawing.Point(170, 752);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 22);
            this.txt_date.TabIndex = 34;
            this.txt_date.ValueChanged += new System.EventHandler(this.txt_date_ValueChanged);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.Location = new System.Drawing.Point(1137, 741);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(187, 53);
            this.btn_purchase.TabIndex = 35;
            this.btn_purchase.Text = "Place Order";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(642, 178);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(56, 24);
            this.lbl_stock.TabIndex = 38;
            this.lbl_stock.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(626, 223);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(83, 22);
            this.txt_stock.TabIndex = 37;
            // 
            // UserControl_purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_paid);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.txt_noofItems);
            this.Controls.Add(this.lbl_net);
            this.Controls.Add(this.lbl_paid);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.lbl_noofitems);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.listView_Purchase);
            this.Controls.Add(this.cmb_selectemid);
            this.Controls.Add(this.Cmb_selectSupplier);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_purchaseID);
            this.Controls.Add(this.txt_sppliername);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_PurchaseID);
            this.Controls.Add(this.lbl_SelectItemID);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_Qty);
            this.Controls.Add(this.lbl_ItemName);
            this.Controls.Add(this.lbl_Suppliername);
            this.Controls.Add(this.lbl_selectSupplier);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_purchase";
            this.Size = new System.Drawing.Size(1379, 829);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_selectSupplier;
        private System.Windows.Forms.Label lbl_Suppliername;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_Qty;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_SelectItemID;
        private System.Windows.Forms.Label lbl_PurchaseID;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_sppliername;
        private System.Windows.Forms.TextBox txt_purchaseID;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox Cmb_selectSupplier;
        private System.Windows.Forms.ComboBox cmb_selectemid;
        private System.Windows.Forms.ListView listView_Purchase;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label lbl_noofitems;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_paid;
        private System.Windows.Forms.Label lbl_net;
        private System.Windows.Forms.TextBox txt_noofItems;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.ColumnHeader Item_name;
        private System.Windows.Forms.ColumnHeader Item_ID;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txt_stock;
    }
}
