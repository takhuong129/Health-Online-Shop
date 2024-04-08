
namespace HealthOnlineShop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Health Food Store";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 578);
            this.panel1.TabIndex = 5;
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnDelivery.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Image")));
            this.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.Location = new System.Drawing.Point(0, 241);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(171, 64);
            this.btnDelivery.TabIndex = 6;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 310);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(171, 64);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 172);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(171, 64);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(171, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(700, 578);
            this.ControlPanel.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 380);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 64);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 578);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button btnLogout;
    }
}