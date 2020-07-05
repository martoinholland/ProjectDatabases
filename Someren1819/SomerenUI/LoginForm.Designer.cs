namespace SomerenUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.pnl_Register = new System.Windows.Forms.Panel();
            this.txt_RegisterEmailAddress = new System.Windows.Forms.TextBox();
            this.lbl_RegisterEmailAddress = new System.Windows.Forms.Label();
            this.btn_RegisterBack = new System.Windows.Forms.Button();
            this.lbl_RegisterError = new System.Windows.Forms.Label();
            this.btn_RegisterConfirm = new System.Windows.Forms.Button();
            this.txt_RegisterLicenceKey = new System.Windows.Forms.TextBox();
            this.txt_RegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.txt_RegisterPassword = new System.Windows.Forms.TextBox();
            this.txt_RegisterUsername = new System.Windows.Forms.TextBox();
            this.lbl_RegisterLicenceKey = new System.Windows.Forms.Label();
            this.lbl_RegisterConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_RegisterPassword = new System.Windows.Forms.Label();
            this.lbl_RegisterUsername = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(146, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(289, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(117, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 64);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(224, 127);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(98, 64);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // pnl_Register
            // 
            this.pnl_Register.Controls.Add(this.txt_RegisterEmailAddress);
            this.pnl_Register.Controls.Add(this.lbl_RegisterEmailAddress);
            this.pnl_Register.Controls.Add(this.btn_RegisterBack);
            this.pnl_Register.Controls.Add(this.lbl_RegisterError);
            this.pnl_Register.Controls.Add(this.btn_RegisterConfirm);
            this.pnl_Register.Controls.Add(this.txt_RegisterLicenceKey);
            this.pnl_Register.Controls.Add(this.txt_RegisterConfirmPassword);
            this.pnl_Register.Controls.Add(this.txt_RegisterPassword);
            this.pnl_Register.Controls.Add(this.txt_RegisterUsername);
            this.pnl_Register.Controls.Add(this.lbl_RegisterLicenceKey);
            this.pnl_Register.Controls.Add(this.lbl_RegisterConfirmPassword);
            this.pnl_Register.Controls.Add(this.lbl_RegisterPassword);
            this.pnl_Register.Controls.Add(this.lbl_RegisterUsername);
            this.pnl_Register.Location = new System.Drawing.Point(9, 10);
            this.pnl_Register.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Register.Name = "pnl_Register";
            this.pnl_Register.Size = new System.Drawing.Size(438, 232);
            this.pnl_Register.TabIndex = 7;
            // 
            // txt_RegisterEmailAddress
            // 
            this.txt_RegisterEmailAddress.Location = new System.Drawing.Point(219, 58);
            this.txt_RegisterEmailAddress.Name = "txt_RegisterEmailAddress";
            this.txt_RegisterEmailAddress.Size = new System.Drawing.Size(207, 20);
            this.txt_RegisterEmailAddress.TabIndex = 12;
            // 
            // lbl_RegisterEmailAddress
            // 
            this.lbl_RegisterEmailAddress.AutoSize = true;
            this.lbl_RegisterEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterEmailAddress.Location = new System.Drawing.Point(10, 54);
            this.lbl_RegisterEmailAddress.Name = "lbl_RegisterEmailAddress";
            this.lbl_RegisterEmailAddress.Size = new System.Drawing.Size(158, 24);
            this.lbl_RegisterEmailAddress.TabIndex = 11;
            this.lbl_RegisterEmailAddress.Text = "E-mail Address:";
            // 
            // btn_RegisterBack
            // 
            this.btn_RegisterBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterBack.Location = new System.Drawing.Point(219, 187);
            this.btn_RegisterBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RegisterBack.Name = "btn_RegisterBack";
            this.btn_RegisterBack.Size = new System.Drawing.Size(98, 37);
            this.btn_RegisterBack.TabIndex = 10;
            this.btn_RegisterBack.Text = "Back";
            this.btn_RegisterBack.UseVisualStyleBackColor = true;
            this.btn_RegisterBack.Click += new System.EventHandler(this.btn_RegisterBack_Click);
            // 
            // lbl_RegisterError
            // 
            this.lbl_RegisterError.ForeColor = System.Drawing.Color.Red;
            this.lbl_RegisterError.Location = new System.Drawing.Point(219, 0);
            this.lbl_RegisterError.Name = "lbl_RegisterError";
            this.lbl_RegisterError.Size = new System.Drawing.Size(207, 26);
            this.lbl_RegisterError.TabIndex = 9;
            this.lbl_RegisterError.Text = "[Sample Text]";
            this.lbl_RegisterError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_RegisterConfirm
            // 
            this.btn_RegisterConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterConfirm.Location = new System.Drawing.Point(328, 187);
            this.btn_RegisterConfirm.Name = "btn_RegisterConfirm";
            this.btn_RegisterConfirm.Size = new System.Drawing.Size(98, 37);
            this.btn_RegisterConfirm.TabIndex = 8;
            this.btn_RegisterConfirm.Text = "Confirm";
            this.btn_RegisterConfirm.UseVisualStyleBackColor = true;
            this.btn_RegisterConfirm.Click += new System.EventHandler(this.btn_RegisterConfirm_Click);
            // 
            // txt_RegisterLicenceKey
            // 
            this.txt_RegisterLicenceKey.Location = new System.Drawing.Point(219, 136);
            this.txt_RegisterLicenceKey.Name = "txt_RegisterLicenceKey";
            this.txt_RegisterLicenceKey.Size = new System.Drawing.Size(207, 20);
            this.txt_RegisterLicenceKey.TabIndex = 7;
            // 
            // txt_RegisterConfirmPassword
            // 
            this.txt_RegisterConfirmPassword.Location = new System.Drawing.Point(219, 110);
            this.txt_RegisterConfirmPassword.Name = "txt_RegisterConfirmPassword";
            this.txt_RegisterConfirmPassword.PasswordChar = '*';
            this.txt_RegisterConfirmPassword.Size = new System.Drawing.Size(207, 20);
            this.txt_RegisterConfirmPassword.TabIndex = 6;
            // 
            // txt_RegisterPassword
            // 
            this.txt_RegisterPassword.Location = new System.Drawing.Point(219, 84);
            this.txt_RegisterPassword.Name = "txt_RegisterPassword";
            this.txt_RegisterPassword.PasswordChar = '*';
            this.txt_RegisterPassword.Size = new System.Drawing.Size(207, 20);
            this.txt_RegisterPassword.TabIndex = 5;
            // 
            // txt_RegisterUsername
            // 
            this.txt_RegisterUsername.Location = new System.Drawing.Point(219, 32);
            this.txt_RegisterUsername.Name = "txt_RegisterUsername";
            this.txt_RegisterUsername.Size = new System.Drawing.Size(207, 20);
            this.txt_RegisterUsername.TabIndex = 4;
            // 
            // lbl_RegisterLicenceKey
            // 
            this.lbl_RegisterLicenceKey.AutoSize = true;
            this.lbl_RegisterLicenceKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterLicenceKey.Location = new System.Drawing.Point(10, 132);
            this.lbl_RegisterLicenceKey.Name = "lbl_RegisterLicenceKey";
            this.lbl_RegisterLicenceKey.Size = new System.Drawing.Size(131, 24);
            this.lbl_RegisterLicenceKey.TabIndex = 3;
            this.lbl_RegisterLicenceKey.Text = "Licence Key:";
            // 
            // lbl_RegisterConfirmPassword
            // 
            this.lbl_RegisterConfirmPassword.AutoSize = true;
            this.lbl_RegisterConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterConfirmPassword.Location = new System.Drawing.Point(10, 106);
            this.lbl_RegisterConfirmPassword.Name = "lbl_RegisterConfirmPassword";
            this.lbl_RegisterConfirmPassword.Size = new System.Drawing.Size(184, 24);
            this.lbl_RegisterConfirmPassword.TabIndex = 2;
            this.lbl_RegisterConfirmPassword.Text = "Confirm Password:";
            // 
            // lbl_RegisterPassword
            // 
            this.lbl_RegisterPassword.AutoSize = true;
            this.lbl_RegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterPassword.Location = new System.Drawing.Point(10, 80);
            this.lbl_RegisterPassword.Name = "lbl_RegisterPassword";
            this.lbl_RegisterPassword.Size = new System.Drawing.Size(106, 24);
            this.lbl_RegisterPassword.TabIndex = 1;
            this.lbl_RegisterPassword.Text = "Password:";
            this.lbl_RegisterPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_RegisterUsername
            // 
            this.lbl_RegisterUsername.AutoSize = true;
            this.lbl_RegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterUsername.Location = new System.Drawing.Point(10, 28);
            this.lbl_RegisterUsername.Name = "lbl_RegisterUsername";
            this.lbl_RegisterUsername.Size = new System.Drawing.Size(117, 24);
            this.lbl_RegisterUsername.TabIndex = 0;
            this.lbl_RegisterUsername.Text = "User name:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(333, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Forgot Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 207);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnl_Register);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.pnl_Register.ResumeLayout(false);
            this.pnl_Register.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Panel pnl_Register;
        private System.Windows.Forms.Label lbl_RegisterLicenceKey;
        private System.Windows.Forms.Label lbl_RegisterConfirmPassword;
        private System.Windows.Forms.Label lbl_RegisterPassword;
        private System.Windows.Forms.Label lbl_RegisterUsername;
        private System.Windows.Forms.Button btn_RegisterConfirm;
        private System.Windows.Forms.TextBox txt_RegisterLicenceKey;
        private System.Windows.Forms.TextBox txt_RegisterConfirmPassword;
        private System.Windows.Forms.TextBox txt_RegisterPassword;
        private System.Windows.Forms.TextBox txt_RegisterUsername;
        private System.Windows.Forms.Label lbl_RegisterError;
        private System.Windows.Forms.Button btn_RegisterBack;
        private System.Windows.Forms.TextBox txt_RegisterEmailAddress;
        private System.Windows.Forms.Label lbl_RegisterEmailAddress;
        private System.Windows.Forms.Button button2;
    }
}