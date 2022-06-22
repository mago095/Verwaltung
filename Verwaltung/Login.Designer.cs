namespace Verwaltung
{
    partial class Login
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
            this.Txt_user = new System.Windows.Forms.TextBox();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_registerPassword = new System.Windows.Forms.TextBox();
            this.Txt_registerUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_registerPassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_user
            // 
            this.Txt_user.Location = new System.Drawing.Point(77, 69);
            this.Txt_user.Name = "Txt_user";
            this.Txt_user.Size = new System.Drawing.Size(100, 20);
            this.Txt_user.TabIndex = 0;
            // 
            // Txt_password
            // 
            this.Txt_password.Location = new System.Drawing.Point(77, 122);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(100, 20);
            this.Txt_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(77, 158);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(75, 23);
            this.Btn_login.TabIndex = 4;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_register
            // 
            this.Btn_register.Location = new System.Drawing.Point(357, 229);
            this.Btn_register.Name = "Btn_register";
            this.Btn_register.Size = new System.Drawing.Size(75, 23);
            this.Btn_register.TabIndex = 10;
            this.Btn_register.Text = "Register";
            this.Btn_register.UseVisualStyleBackColor = true;
            this.Btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "User";
            // 
            // Txt_registerPassword
            // 
            this.Txt_registerPassword.Location = new System.Drawing.Point(357, 122);
            this.Txt_registerPassword.Name = "Txt_registerPassword";
            this.Txt_registerPassword.PasswordChar = '*';
            this.Txt_registerPassword.Size = new System.Drawing.Size(100, 20);
            this.Txt_registerPassword.TabIndex = 7;
            // 
            // Txt_registerUser
            // 
            this.Txt_registerUser.Location = new System.Drawing.Point(357, 69);
            this.Txt_registerUser.Name = "Txt_registerUser";
            this.Txt_registerUser.Size = new System.Drawing.Size(100, 20);
            this.Txt_registerUser.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Register";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Repeat Password";
            // 
            // Txt_registerPassword2
            // 
            this.Txt_registerPassword2.Location = new System.Drawing.Point(357, 178);
            this.Txt_registerPassword2.Name = "Txt_registerPassword2";
            this.Txt_registerPassword2.Size = new System.Drawing.Size(100, 20);
            this.Txt_registerPassword2.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 443);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_registerPassword2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_registerPassword);
            this.Controls.Add(this.Txt_registerUser);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.Txt_user);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_user;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_registerPassword;
        private System.Windows.Forms.TextBox Txt_registerUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_registerPassword2;
    }
}