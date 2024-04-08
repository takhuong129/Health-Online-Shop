
namespace HealthOnlineShop
{
    partial class frmSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 205);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please enter user information.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sign Up";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(122, 370);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(166, 33);
            this.btnSignup.TabIndex = 11;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbPassword.Location = new System.Drawing.Point(12, 274);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(180, 31);
            this.txbPassword.TabIndex = 10;
            this.txbPassword.Text = "Password";
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.White;
            this.txbUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbUsername.Location = new System.Drawing.Point(13, 237);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(179, 31);
            this.txbUsername.TabIndex = 9;
            this.txbUsername.Text = "Username";
            // 
            // txbFullname
            // 
            this.txbFullname.BackColor = System.Drawing.Color.White;
            this.txbFullname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbFullname.Location = new System.Drawing.Point(218, 237);
            this.txbFullname.Multiline = true;
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(181, 31);
            this.txbFullname.TabIndex = 12;
            this.txbFullname.Text = "Fullname";
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.Color.White;
            this.txbAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbAddress.Location = new System.Drawing.Point(11, 311);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(181, 31);
            this.txbAddress.TabIndex = 13;
            this.txbAddress.Text = "Address";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txbPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbPhoneNumber.Location = new System.Drawing.Point(218, 274);
            this.txbPhoneNumber.Multiline = true;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(181, 31);
            this.txbPhoneNumber.TabIndex = 14;
            this.txbPhoneNumber.Text = "Phone Number";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbEmail.Location = new System.Drawing.Point(218, 311);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(179, 31);
            this.txbEmail.TabIndex = 15;
            this.txbEmail.Text = "Email";
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 536);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbFullname);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.panel1);
            this.Name = "frmSignup";
            this.Text = "frmSignup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbEmail;
    }
}