namespace pharmacy
{
    partial class UserControl_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_items));
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_Costprice = new System.Windows.Forms.Label();
            this.lbl_saleprice = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.dataItems = new System.Windows.Forms.DataGridView();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_pricecost = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemID.Location = new System.Drawing.Point(244, 116);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(67, 24);
            this.lbl_itemID.TabIndex = 0;
            this.lbl_itemID.Text = "Item ID";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(244, 150);
            this.lbl_itemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(101, 24);
            this.lbl_itemname.TabIndex = 1;
            this.lbl_itemname.Text = "Item Name";
            // 
            // lbl_Costprice
            // 
            this.lbl_Costprice.AutoSize = true;
            this.lbl_Costprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Costprice.Location = new System.Drawing.Point(244, 267);
            this.lbl_Costprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Costprice.Name = "lbl_Costprice";
            this.lbl_Costprice.Size = new System.Drawing.Size(95, 24);
            this.lbl_Costprice.TabIndex = 2;
            this.lbl_Costprice.Text = "Cost Price";
            // 
            // lbl_saleprice
            // 
            this.lbl_saleprice.AutoSize = true;
            this.lbl_saleprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saleprice.Location = new System.Drawing.Point(244, 308);
            this.lbl_saleprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saleprice.Name = "lbl_saleprice";
            this.lbl_saleprice.Size = new System.Drawing.Size(95, 24);
            this.lbl_saleprice.TabIndex = 3;
            this.lbl_saleprice.Text = "Sale Price";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(244, 348);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(38, 24);
            this.lbl_qty.TabIndex = 4;
            this.lbl_qty.Text = "Qty";
            // 
            // dataItems
            // 
            this.dataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItems.Location = new System.Drawing.Point(112, 538);
            this.dataItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataItems.Name = "dataItems";
            this.dataItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItems.Size = new System.Drawing.Size(855, 238);
            this.dataItems.TabIndex = 6;
            this.dataItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_item_MouseDoubleClick);
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(361, 117);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(130, 22);
            this.txt_itemID.TabIndex = 7;
            // 
            // txt_item_name
            // 
            this.txt_item_name.Location = new System.Drawing.Point(361, 152);
            this.txt_item_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(223, 22);
            this.txt_item_name.TabIndex = 8;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(361, 195);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(223, 66);
            this.txt_description.TabIndex = 9;
            // 
            // txt_pricecost
            // 
            this.txt_pricecost.Location = new System.Drawing.Point(361, 271);
            this.txt_pricecost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pricecost.Name = "txt_pricecost";
            this.txt_pricecost.Size = new System.Drawing.Size(130, 22);
            this.txt_pricecost.TabIndex = 10;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(361, 347);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(130, 22);
            this.txt_qty.TabIndex = 11;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(244, 193);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(104, 24);
            this.lbl_description.TabIndex = 12;
            this.lbl_description.Text = "Description";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(361, 310);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(130, 22);
            this.txt_price.TabIndex = 13;
            // 
            // btn_insert
            // 
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(538, 400);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(241, 82);
            this.btn_insert.TabIndex = 14;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(811, 274);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(241, 82);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_update.Location = new System.Drawing.Point(811, 152);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(241, 82);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(811, 396);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(241, 82);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Items";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(991, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 82);
            this.button1.TabIndex = 19;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_pricecost);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_item_name);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.dataItems);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_saleprice);
            this.Controls.Add(this.lbl_Costprice);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_itemID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_items";
            this.Size = new System.Drawing.Size(1260, 810);
            this.Load += new System.EventHandler(this.UserControl_items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_Costprice;
        private System.Windows.Forms.Label lbl_saleprice;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.DataGridView dataItems;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_pricecost;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
