namespace InventorySystem
{
    partial class POSBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderidTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeidTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.grandTotalTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantityTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.orderidTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.barcodeidTextbox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(969, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 80);
            this.button2.TabIndex = 10;
            this.button2.Text = "Make Payment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grand Total";
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(740, 311);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.grandTotalTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.Location = new System.Drawing.Point(740, 198);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(351, 22);
            this.quantityTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "order id";
            // 
            // orderidTextbox
            // 
            this.orderidTextbox.Location = new System.Drawing.Point(740, 37);
            this.orderidTextbox.Name = "orderidTextbox";
            this.orderidTextbox.ReadOnly = true;
            this.orderidTextbox.Size = new System.Drawing.Size(100, 20);
            this.orderidTextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barcode";
            // 
            // barcodeidTextbox
            // 
            this.barcodeidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeidTextbox.Location = new System.Drawing.Point(750, 112);
            this.barcodeidTextbox.Name = "barcodeidTextbox";
            this.barcodeidTextbox.Size = new System.Drawing.Size(381, 22);
            this.barcodeidTextbox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 657);
            this.dataGridView1.TabIndex = 0;
            // 
            // POSBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "POSBoard";
            this.Text = "POSBoard";
            this.Load += new System.EventHandler(this.POSBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeidTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderidTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.Button button2;
    }
}