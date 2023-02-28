namespace InventorySystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventoryDash = new App.Forms.InventoryDash();
            this.userDash = new App.Forms.UserDash();
            this.panel1.SuspendLayout();
            this.sidebarLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sidebarLayout);
            this.panel1.Controls.Add(this.logoPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 681);
            this.panel1.TabIndex = 0;
            // 
            // sidebarLayout
            // 
            this.sidebarLayout.ColumnCount = 2;
            this.sidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.sidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.sidebarLayout.Controls.Add(this.button4, 1, 3);
            this.sidebarLayout.Controls.Add(this.button3, 1, 2);
            this.sidebarLayout.Controls.Add(this.button2, 1, 1);
            this.sidebarLayout.Controls.Add(this.iconPictureBox4, 0, 3);
            this.sidebarLayout.Controls.Add(this.iconPictureBox1, 0, 0);
            this.sidebarLayout.Controls.Add(this.iconPictureBox2, 0, 1);
            this.sidebarLayout.Controls.Add(this.iconPictureBox3, 0, 2);
            this.sidebarLayout.Controls.Add(this.button1, 1, 0);
            this.sidebarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarLayout.Location = new System.Drawing.Point(0, 136);
            this.sidebarLayout.Name = "sidebarLayout";
            this.sidebarLayout.RowCount = 5;
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sidebarLayout.Size = new System.Drawing.Size(222, 545);
            this.sidebarLayout.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(58, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 103);
            this.button4.TabIndex = 7;
            this.button4.Text = "Barcode List";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(58, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 103);
            this.button3.TabIndex = 6;
            this.button3.Text = "Inventory List";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.showInventory);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(58, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 103);
            this.button2.TabIndex = 5;
            this.button2.Text = "Product List";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showProduct);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.iconPictureBox4.IconColor = System.Drawing.Color.White;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(11, 365);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 3;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, 38);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(11, 147);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(11, 256);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 2;
            this.iconPictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(58, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 103);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showDashboard);
            // 
            // logoPanel
            // 
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(222, 136);
            this.logoPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inventoryDash);
            this.panel2.Controls.Add(this.userDash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 681);
            this.panel2.TabIndex = 1;
            // 
            // inventoryDash
            // 
            this.inventoryDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDash.Location = new System.Drawing.Point(0, 0);
            this.inventoryDash.Name = "inventoryDash";
            this.inventoryDash.Size = new System.Drawing.Size(1042, 681);
            this.inventoryDash.TabIndex = 1;
            this.inventoryDash.Visible = false;
            // 
            // userDash
            // 
            this.userDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDash.Location = new System.Drawing.Point(0, 0);
            this.userDash.Name = "userDash";
            this.userDash.Size = new System.Drawing.Size(1042, 681);
            this.userDash.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.sidebarLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.TableLayoutPanel sidebarLayout;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private App.Forms.UserDash userDash;
        private App.Forms.InventoryDash inventoryDash;
    }
}