
namespace HealthOnlineShop
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.txbSearching = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listCatalog = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.itemLayout = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearching
            // 
            this.txbSearching.Location = new System.Drawing.Point(34, 16);
            this.txbSearching.Multiline = true;
            this.txbSearching.Name = "txbSearching";
            this.txbSearching.Size = new System.Drawing.Size(187, 33);
            this.txbSearching.TabIndex = 0;
            this.txbSearching.Text = "Searching Here...";
            this.txbSearching.TextChanged += new System.EventHandler(this.txbSearching_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listCatalog
            // 
            this.listCatalog.FormattingEnabled = true;
            this.listCatalog.Location = new System.Drawing.Point(371, 24);
            this.listCatalog.Name = "listCatalog";
            this.listCatalog.Size = new System.Drawing.Size(168, 25);
            this.listCatalog.TabIndex = 2;
            this.listCatalog.SelectedIndexChanged += new System.EventHandler(this.listCatalog_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.listCatalog);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txbSearching);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 76);
            this.panel1.TabIndex = 7;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(598, 9);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(122, 42);
            this.btnCart.TabIndex = 8;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // itemLayout
            // 
            this.itemLayout.AutoScroll = true;
            this.itemLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemLayout.Location = new System.Drawing.Point(0, 76);
            this.itemLayout.Name = "itemLayout";
            this.itemLayout.Size = new System.Drawing.Size(700, 512);
            this.itemLayout.TabIndex = 8;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 588);
            this.Controls.Add(this.itemLayout);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearching;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox listCatalog;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel itemLayout;
        private System.Windows.Forms.Button btnCart;
    }
}