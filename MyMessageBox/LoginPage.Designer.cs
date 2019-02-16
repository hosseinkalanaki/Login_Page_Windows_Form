namespace MyMessageBox
{
    partial class LoginPage
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
            this.messagelabel = new System.Windows.Forms.Label();
            this.erase = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // messagelabel
            // 
            this.messagelabel.Font = new System.Drawing.Font("B Kamran", 18F);
            this.messagelabel.Location = new System.Drawing.Point(14, 9);
            this.messagelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(430, 41);
            this.messagelabel.TabIndex = 0;
            this.messagelabel.Text = "جهت وارد شدن به برنامه نام کاربری و رمز عبور خود را وارد کنید.";
            // 
            // erase
            // 
            this.erase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.erase.Font = new System.Drawing.Font("B Kamran", 16F);
            this.erase.Location = new System.Drawing.Point(192, 134);
            this.erase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(73, 68);
            this.erase.TabIndex = 1;
            this.erase.Text = "پاک کردن";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // login
            // 
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("B Kamran", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.login.Location = new System.Drawing.Point(109, 134);
            this.login.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(73, 68);
            this.login.TabIndex = 2;
            this.login.Text = "ورود";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("B Kamran", 18F);
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Kamran", 18F);
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "رمز عبور   :";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(109, 51);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(178, 34);
            this.userName.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(109, 91);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(178, 34);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = true;
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("B Kamran", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exit.Location = new System.Drawing.Point(275, 134);
            this.exit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(73, 68);
            this.exit.TabIndex = 7;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.Location = new System.Drawing.Point(293, 101);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(15, 14);
            this.checkPassword.TabIndex = 8;
            this.checkPassword.UseVisualStyleBackColor = true;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(458, 222);
            this.ControlBox = false;
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.messagelabel);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LoginPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button login;
        public System.Windows.Forms.Label messagelabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.CheckBox checkPassword;
    }
}

