namespace pharmacy.Reports
{
    partial class searchInvoive
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
            this.lbl_invoiceId = new System.Windows.Forms.Label();
            this.txt_invoiceId = new System.Windows.Forms.TextBox();
            this.btn_searchInvoice = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lbl_invoiceId
            // 
            this.lbl_invoiceId.AutoSize = true;
            this.lbl_invoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceId.Location = new System.Drawing.Point(361, 17);
            this.lbl_invoiceId.Name = "lbl_invoiceId";
            this.lbl_invoiceId.Size = new System.Drawing.Size(128, 29);
            this.lbl_invoiceId.TabIndex = 0;
            this.lbl_invoiceId.Text = "Invoice ID";
            // 
            // txt_invoiceId
            // 
            this.txt_invoiceId.Location = new System.Drawing.Point(495, 17);
            this.txt_invoiceId.Name = "txt_invoiceId";
            this.txt_invoiceId.Size = new System.Drawing.Size(138, 22);
            this.txt_invoiceId.TabIndex = 1;
            // 
            // btn_searchInvoice
            // 
            this.btn_searchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchInvoice.Location = new System.Drawing.Point(673, 16);
            this.btn_searchInvoice.Name = "btn_searchInvoice";
            this.btn_searchInvoice.Size = new System.Drawing.Size(148, 33);
            this.btn_searchInvoice.TabIndex = 2;
            this.btn_searchInvoice.Text = "Search Invoice";
            this.btn_searchInvoice.UseVisualStyleBackColor = true;
            this.btn_searchInvoice.Click += new System.EventHandler(this.btn_searchInvoice_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 82);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1234, 805);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // searchInvoive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 899);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_searchInvoice);
            this.Controls.Add(this.txt_invoiceId);
            this.Controls.Add(this.lbl_invoiceId);
            this.Name = "searchInvoive";
            this.Text = "searchInvoive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_invoiceId;
        private System.Windows.Forms.TextBox txt_invoiceId;
        private System.Windows.Forms.Button btn_searchInvoice;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}