namespace InventorySystem.Forms
{
    partial class formProductReport
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
            this.reportProduct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportProduct
            // 
            this.reportProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportProduct.Location = new System.Drawing.Point(0, 0);
            this.reportProduct.Name = "reportProduct";
            this.reportProduct.ServerReport.BearerToken = null;
            this.reportProduct.Size = new System.Drawing.Size(1028, 668);
            this.reportProduct.TabIndex = 0;
            // 
            // formProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 668);
            this.Controls.Add(this.reportProduct);
            this.Name = "formProductReport";
            this.Text = "ProductReport";
            this.Load += new System.EventHandler(this.formProductReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportProduct;
    }
}