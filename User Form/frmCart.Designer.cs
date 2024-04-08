
namespace HealthOnlineShop
{
    partial class frmCart
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.cartLayout = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "QTY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ITEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 47);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 102);
            this.panel2.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(32, 41);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(394, 61);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(339, 0);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(34, 25);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Price";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnClearAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 30);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Click on a product in the store to increase the quantity.";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(59)))));
            this.btnClearAll.Location = new System.Drawing.Point(369, 3);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(87, 23);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // cartLayout
            // 
            this.cartLayout.AutoScroll = true;
            this.cartLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartLayout.Location = new System.Drawing.Point(0, 77);
            this.cartLayout.Name = "cartLayout";
            this.cartLayout.Size = new System.Drawing.Size(460, 308);
            this.cartLayout.TabIndex = 4;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 487);
            this.Controls.Add(this.cartLayout);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCart";
            this.Text = "frmCart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel cartLayout;
        private System.Windows.Forms.Label label5;
    }
}