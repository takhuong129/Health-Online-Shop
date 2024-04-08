
using System.Windows.Forms;

namespace HealthOnlineShop
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.labelExtraInfo = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerAccount = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "My details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(26, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 2);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personal Information";
            // 
            // txbFullname
            // 
            this.txbFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txbFullname.Location = new System.Drawing.Point(244, 152);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(156, 25);
            this.txbFullname.TabIndex = 5;
            this.txbFullname.Text = "Cuong Peter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fullname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txbEmail.Location = new System.Drawing.Point(484, 152);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(156, 25);
            this.txbEmail.TabIndex = 7;
            this.txbEmail.Text = "Cuong Peter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number";
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txbPhone.Location = new System.Drawing.Point(484, 228);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(156, 25);
            this.txbPhone.TabIndex = 11;
            this.txbPhone.Text = "Cuong Peter";
            // 
            // labelExtraInfo
            // 
            this.labelExtraInfo.AutoSize = true;
            this.labelExtraInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraInfo.Location = new System.Drawing.Point(241, 275);
            this.labelExtraInfo.Name = "labelExtraInfo";
            this.labelExtraInfo.Size = new System.Drawing.Size(57, 17);
            this.labelExtraInfo.TabIndex = 14;
            this.labelExtraInfo.Text = "Address";
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txbAddress.Location = new System.Drawing.Point(244, 302);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(396, 49);
            this.txbAddress.TabIndex = 13;
            this.txbAddress.Text = "Cuong Peter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Account Information";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(27, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 2);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(481, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txbPassword.Location = new System.Drawing.Point(484, 428);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(156, 25);
            this.txbPassword.TabIndex = 20;
            this.txbPassword.Text = "Cuong Peter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(241, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Username";
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txbUsername.Location = new System.Drawing.Point(244, 428);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(156, 25);
            this.txbUsername.TabIndex = 18;
            this.txbUsername.Text = "Cuong Peter";
            this.txbUsername.Cursor = Cursors.Arrow;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(117)))), ((int)(((byte)(209)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(244, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 47);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(27, 544);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 2);
            this.panel3.TabIndex = 16;
            // 
            // dateTimePickerAccount
            // 
            this.dateTimePickerAccount.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAccount.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAccount.Location = new System.Drawing.Point(244, 228);
            this.dateTimePickerAccount.Name = "dateTimePickerAccount";
            this.dateTimePickerAccount.ShowUpDown = true;
            this.dateTimePickerAccount.Size = new System.Drawing.Size(156, 25);
            this.dateTimePickerAccount.TabIndex = 23;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 588);
            this.Controls.Add(this.dateTimePickerAccount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelExtraInfo);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label labelExtraInfo;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccount;
    }
}