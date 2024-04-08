
namespace HealthOnlineShop
{
    partial class ucItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItems));
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgProduct = new System.Windows.Forms.PictureBox();
            this.txtPName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgProduct);
            this.panel2.Controls.Add(this.txtPName);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 126);
            this.panel2.TabIndex = 9;
            // 
            // imgProduct
            // 
            this.imgProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.imgProduct.BackColor = System.Drawing.Color.Transparent;
            this.imgProduct.Image = ((System.Drawing.Image)(resources.GetObject("imgProduct.Image")));
            this.imgProduct.Location = new System.Drawing.Point(11, 3);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(82, 71);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduct.TabIndex = 2;
            this.imgProduct.TabStop = false;
            this.imgProduct.Click += new System.EventHandler(this.imgProduct_Click);
            this.imgProduct.MouseHover += new System.EventHandler(this.imgProduct_MouseHover);
            // 
            // txtPName
            // 
            this.txtPName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPName.AutoSize = true;
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.ForeColor = System.Drawing.Color.Black;
            this.txtPName.Location = new System.Drawing.Point(3, 85);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(90, 20);
            this.txtPName.TabIndex = 1;
            this.txtPName.Tag = "";
            this.txtPName.Text = "Coconut Oil";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.txtPrice.Location = new System.Drawing.Point(3, 105);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(50, 21);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Tag = "";
            this.txtPrice.Text = "$12.5";
            // 
            // ucItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Name = "ucItems";
            this.Size = new System.Drawing.Size(118, 133);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.Label txtPName;
        private System.Windows.Forms.Label txtPrice;
    }
}
