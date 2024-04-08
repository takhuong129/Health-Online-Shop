
namespace HealthOnlineShop
{
    partial class frmLogin
    { /// <summary>
      ///  Required designer variable.
      /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSwitchSU = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.White;
            this.txbUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbUsername.Location = new System.Drawing.Point(115, 228);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(167, 31);
            this.txbUsername.TabIndex = 2;
            this.txbUsername.Text = "Username";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbPassword.Location = new System.Drawing.Point(115, 271);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(167, 31);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(115, 322);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(166, 33);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sign in";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 205);
            this.panel1.TabIndex = 7;
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
            // btnSwitchSU
            // 
            this.btnSwitchSU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(194)))), ((int)(((byte)(172)))));
            this.btnSwitchSU.ForeColor = System.Drawing.Color.White;
            this.btnSwitchSU.Location = new System.Drawing.Point(115, 370);
            this.btnSwitchSU.Name = "btnSwitchSU";
            this.btnSwitchSU.Size = new System.Drawing.Size(166, 33);
            this.btnSwitchSU.TabIndex = 8;
            this.btnSwitchSU.Text = "Sign Up";
            this.btnSwitchSU.UseVisualStyleBackColor = false;
            this.btnSwitchSU.Click += new System.EventHandler(this.btnSwitchSU_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.btnSwitchSU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSwitchSU;
    }
}