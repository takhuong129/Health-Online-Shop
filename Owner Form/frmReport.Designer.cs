
namespace HealthOnlineShop
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.reportTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpPeriod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTO = new System.Windows.Forms.Label();
            this.txbTS = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSaleProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTable
            // 
            this.reportTable.AllowUserToAddRows = false;
            this.reportTable.AllowUserToDeleteRows = false;
            this.reportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colProductID,
            this.colCategory,
            this.colQTY,
            this.colTotalSaleProduct});
            this.reportTable.Location = new System.Drawing.Point(59, 147);
            this.reportTable.Name = "reportTable";
            this.reportTable.ReadOnly = true;
            this.reportTable.Size = new System.Drawing.Size(542, 265);
            this.reportTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 81);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(264, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Statistics Report";
            // 
            // dpPeriod
            // 
            this.dpPeriod.CustomFormat = "dd/MM/yyyy";
            this.dpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpPeriod.Location = new System.Drawing.Point(269, 108);
            this.dpPeriod.Name = "dpPeriod";
            this.dpPeriod.Size = new System.Drawing.Size(200, 20);
            this.dpPeriod.TabIndex = 9;
            this.dpPeriod.ValueChanged += new System.EventHandler(this.dpPeriod_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Sale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Order:";
            // 
            // txbTO
            // 
            this.txbTO.AutoSize = true;
            this.txbTO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTO.ForeColor = System.Drawing.Color.ForestGreen;
            this.txbTO.Location = new System.Drawing.Point(148, 0);
            this.txbTO.Name = "txbTO";
            this.txbTO.Size = new System.Drawing.Size(0, 32);
            this.txbTO.TabIndex = 12;
            // 
            // txbTS
            // 
            this.txbTS.AutoSize = true;
            this.txbTS.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTS.ForeColor = System.Drawing.Color.ForestGreen;
            this.txbTS.Location = new System.Drawing.Point(148, 57);
            this.txbTS.Name = "txbTS";
            this.txbTS.Size = new System.Drawing.Size(0, 32);
            this.txbTS.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.txbTO);
            this.panel2.Controls.Add(this.txbTS);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(115, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 100);
            this.panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filter (month, year):";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "Product";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colQTY
            // 
            this.colQTY.HeaderText = "Quantity Sold";
            this.colQTY.Name = "colQTY";
            this.colQTY.ReadOnly = true;
            // 
            // colTotalSaleProduct
            // 
            this.colTotalSaleProduct.HeaderText = "Total Sale";
            this.colTotalSaleProduct.Name = "colTotalSaleProduct";
            this.colTotalSaleProduct.ReadOnly = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dpPeriod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txbTO;
        private System.Windows.Forms.Label txbTS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSaleProduct;
    }
}