namespace SomerenUI
{
    partial class Password1
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.lbl_SecretQuestion = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.btn_Continue2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_newQ = new System.Windows.Forms.TextBox();
            this.textBox_newA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your username:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(9, 29);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(189, 20);
            this.textBox_username.TabIndex = 1;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(214, 27);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(75, 23);
            this.btn_Continue.TabIndex = 2;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // lbl_SecretQuestion
            // 
            this.lbl_SecretQuestion.AutoSize = true;
            this.lbl_SecretQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_SecretQuestion.Location = new System.Drawing.Point(9, 58);
            this.lbl_SecretQuestion.Name = "lbl_SecretQuestion";
            this.lbl_SecretQuestion.Size = new System.Drawing.Size(0, 17);
            this.lbl_SecretQuestion.TabIndex = 3;
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(9, 78);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(189, 20);
            this.textBox_Answer.TabIndex = 4;
            // 
            // btn_Continue2
            // 
            this.btn_Continue2.Location = new System.Drawing.Point(74, 119);
            this.btn_Continue2.Name = "btn_Continue2";
            this.btn_Continue2.Size = new System.Drawing.Size(146, 29);
            this.btn_Continue2.TabIndex = 5;
            this.btn_Continue2.Text = "Continue";
            this.btn_Continue2.UseVisualStyleBackColor = true;
            this.btn_Continue2.Click += new System.EventHandler(this.btn_Continue2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(204, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wrong Answer!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter new password:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(198, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "*minimum 8 characters, 1 capital, 1 lowercase letter, special symbol";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(74, 359);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(146, 39);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset Password";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter new security question:";
            // 
            // textBox_newQ
            // 
            this.textBox_newQ.Location = new System.Drawing.Point(9, 243);
            this.textBox_newQ.Name = "textBox_newQ";
            this.textBox_newQ.Size = new System.Drawing.Size(186, 20);
            this.textBox_newQ.TabIndex = 12;
            // 
            // textBox_newA
            // 
            this.textBox_newA.Location = new System.Drawing.Point(9, 299);
            this.textBox_newA.Name = "textBox_newA";
            this.textBox_newA.Size = new System.Drawing.Size(186, 20);
            this.textBox_newA.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(9, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter new answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password does not meet minimum requirements!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label8.Location = new System.Drawing.Point(198, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "*not required";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.Location = new System.Drawing.Point(198, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "*not required";
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Location = new System.Drawing.Point(9, 185);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.PasswordChar = '•';
            this.textBox_newPassword.Size = new System.Drawing.Size(186, 20);
            this.textBox_newPassword.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "New secret question not set.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(44, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "↓ Enter new details below ↓";
            // 
            // Password1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 401);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_newPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_newA);
            this.Controls.Add(this.textBox_newQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Continue2);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.lbl_SecretQuestion);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Name = "Password1";
            this.Text = "Password reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Label lbl_SecretQuestion;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Button btn_Continue2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_newQ;
        private System.Windows.Forms.TextBox textBox_newA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}