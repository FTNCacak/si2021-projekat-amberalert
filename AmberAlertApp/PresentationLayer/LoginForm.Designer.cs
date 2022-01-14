
namespace PresentationLayer
{
    partial class LoginForm
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
            this.LogIn = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.PictureBox();
            this.Badge = new System.Windows.Forms.PictureBox();
            this.AmberAlertLogo = new System.Windows.Forms.PictureBox();
            this.ExitLogin = new System.Windows.Forms.PictureBox();
            this.LoginBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.NewAccount = new System.Windows.Forms.Label();
            this.textBoxBadge = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Badge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmberAlertLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.AutoSize = true;
            this.LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.LogIn.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LogIn.Location = new System.Drawing.Point(118, 48);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(119, 48);
            this.LogIn.TabIndex = 3;
            this.LogIn.Text = "LOG IN";
            this.LogIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Password.Image = global::PresentationLayer.Properties.Resources.padlock__1_;
            this.Password.Location = new System.Drawing.Point(62, 182);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(40, 23);
            this.Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Password.TabIndex = 5;
            this.Password.TabStop = false;
            // 
            // Badge
            // 
            this.Badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Badge.Image = global::PresentationLayer.Properties.Resources.badge;
            this.Badge.Location = new System.Drawing.Point(62, 119);
            this.Badge.Name = "Badge";
            this.Badge.Size = new System.Drawing.Size(40, 23);
            this.Badge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Badge.TabIndex = 4;
            this.Badge.TabStop = false;
            // 
            // AmberAlertLogo
            // 
            this.AmberAlertLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.AmberAlertLogo.Image = global::PresentationLayer.Properties.Resources.logosvi;
            this.AmberAlertLogo.Location = new System.Drawing.Point(12, 375);
            this.AmberAlertLogo.Name = "AmberAlertLogo";
            this.AmberAlertLogo.Size = new System.Drawing.Size(110, 63);
            this.AmberAlertLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AmberAlertLogo.TabIndex = 2;
            this.AmberAlertLogo.TabStop = false;
            // 
            // ExitLogin
            // 
            this.ExitLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ExitLogin.Image = global::PresentationLayer.Properties.Resources.x;
            this.ExitLogin.Location = new System.Drawing.Point(12, 12);
            this.ExitLogin.Name = "ExitLogin";
            this.ExitLogin.Size = new System.Drawing.Size(32, 25);
            this.ExitLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitLogin.TabIndex = 1;
            this.ExitLogin.TabStop = false;
            this.ExitLogin.Click += new System.EventHandler(this.ExitLogin_Click);
            // 
            // LoginBackground
            // 
            this.LoginBackground.Image = global::PresentationLayer.Properties.Resources.promena;
            this.LoginBackground.Location = new System.Drawing.Point(-173, -123);
            this.LoginBackground.Name = "LoginBackground";
            this.LoginBackground.Size = new System.Drawing.Size(951, 608);
            this.LoginBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginBackground.TabIndex = 0;
            this.LoginBackground.TabStop = false;
            this.LoginBackground.Click += new System.EventHandler(this.LoginBackground_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(62, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel2.Location = new System.Drawing.Point(62, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 1);
            this.panel2.TabIndex = 7;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.buttonLogin.Location = new System.Drawing.Point(83, 264);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(190, 44);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // NewAccount
            // 
            this.NewAccount.AutoSize = true;
            this.NewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.NewAccount.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.NewAccount.Location = new System.Drawing.Point(104, 323);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(133, 23);
            this.NewAccount.TabIndex = 9;
            this.NewAccount.Text = "dodajte nov nalog";
            this.NewAccount.Click += new System.EventHandler(this.NewAccount_Click);
            // 
            // textBoxBadge
            // 
            this.textBoxBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBoxBadge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBadge.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(14)))));
            this.textBoxBadge.Location = new System.Drawing.Point(109, 119);
            this.textBoxBadge.Name = "textBoxBadge";
            this.textBoxBadge.Size = new System.Drawing.Size(190, 27);
            this.textBoxBadge.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(14)))));
            this.textBoxPassword.Location = new System.Drawing.Point(109, 183);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(190, 27);
            this.textBoxPassword.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxBadge);
            this.Controls.Add(this.NewAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Badge);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.AmberAlertLogo);
            this.Controls.Add(this.ExitLogin);
            this.Controls.Add(this.LoginBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Badge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmberAlertLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginBackground;
        private System.Windows.Forms.PictureBox ExitLogin;
        private System.Windows.Forms.PictureBox AmberAlertLogo;
        private System.Windows.Forms.Label LogIn;
        private System.Windows.Forms.PictureBox Badge;
        private System.Windows.Forms.PictureBox Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label NewAccount;
        private System.Windows.Forms.TextBox textBoxBadge;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

