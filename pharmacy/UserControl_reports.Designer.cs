namespace pharmacy
{
    partial class UserControl_reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnItemReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_LowStock = new System.Windows.Forms.Button();
            this.btn_commonItems = new System.Windows.Forms.Button();
            this.btn_day_summery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // btnItemReport
            // 
            this.btnItemReport.Location = new System.Drawing.Point(261, 165);
            this.btnItemReport.Name = "btnItemReport";
            this.btnItemReport.Size = new System.Drawing.Size(151, 68);
            this.btnItemReport.TabIndex = 1;
            this.btnItemReport.Text = "Item Report";
            this.btnItemReport.UseVisualStyleBackColor = true;
            this.btnItemReport.Click += new System.EventHandler(this.btnItemReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Customer Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "Purchase Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "Supplier Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sales Invoice";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_LowStock
            // 
            this.btn_LowStock.Location = new System.Drawing.Point(671, 289);
            this.btn_LowStock.Name = "btn_LowStock";
            this.btn_LowStock.Size = new System.Drawing.Size(151, 66);
            this.btn_LowStock.TabIndex = 6;
            this.btn_LowStock.Text = "Low Stock";
            this.btn_LowStock.UseVisualStyleBackColor = true;
            this.btn_LowStock.Click += new System.EventHandler(this.btn_LowStock_Click);
            // 
            // btn_commonItems
            // 
            this.btn_commonItems.Location = new System.Drawing.Point(261, 413);
            this.btn_commonItems.Name = "btn_commonItems";
            this.btn_commonItems.Size = new System.Drawing.Size(151, 66);
            this.btn_commonItems.TabIndex = 7;
            this.btn_commonItems.Text = "Show Most Commom Items";
            this.btn_commonItems.UseVisualStyleBackColor = true;
            this.btn_commonItems.Click += new System.EventHandler(this.btn_commonItems_Click);
            // 
            // btn_day_summery
            // 
            this.btn_day_summery.Location = new System.Drawing.Point(462, 413);
            this.btn_day_summery.Name = "btn_day_summery";
            this.btn_day_summery.Size = new System.Drawing.Size(151, 66);
            this.btn_day_summery.TabIndex = 8;
            this.btn_day_summery.Text = "Day Summery";
            this.btn_day_summery.UseVisualStyleBackColor = true;
            this.btn_day_summery.Click += new System.EventHandler(this.btn_day_summery_Click);
            // 
            // UserControl_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_day_summery);
            this.Controls.Add(this.btn_commonItems);
            this.Controls.Add(this.btn_LowStock);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnItemReport);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_reports";
            this.Size = new System.Drawing.Size(1107, 592);
            this.Load += new System.EventHandler(this.UserControl_reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItemReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_LowStock;
        private System.Windows.Forms.Button btn_commonItems;
        private System.Windows.Forms.Button btn_day_summery;
    }
}
