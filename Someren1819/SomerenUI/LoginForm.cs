using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenDAL;

namespace SomerenUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            pnl_Register.Hide();
            lbl_RegisterError.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SomerenLogic.Login_Service loginService = new SomerenLogic.Login_Service();
            List<Login> loginList = loginService.GetLogin();
            string email = txtUserName.Text;

            bool Isadmin = false;
            bool Isright = false;
            foreach (var s in loginList)
            {
                if ((s.UserName == txtUserName.Text) && (s.Password == txtPassword.Text))
                {
                    this.Hide();                                        
                    if (s.Type == "admin")
                    {
                        Isadmin = true;
                    }
                    SomerenUI someren = new SomerenUI(Isadmin, $"{email}");
                    someren.ShowDialog();
                    this.Close();
                    break;
                }
                else
                {
                    Isright = true;
                }
            }
            if (Isright = true)
            {
                MessageBox.Show("Invalid user name or password!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            txtPassword.Hide();
            txtUserName.Hide();
            label1.Hide();
            label2.Hide();
            btnLogin.Hide();
            btn_Register.Hide();
            button1.Hide();
            button2.Hide();
            pnl_Register.Show();
            this.Size = new System.Drawing.Size(472, 292);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_RegisterBack_Click(object sender, EventArgs e)
        {
            txtPassword.Show();
            txtUserName.Show();
            label1.Show();
            label2.Show();
            btnLogin.Show();
            btn_Register.Show();
            button1.Show();
            button2.Show();

            this.Size = new System.Drawing.Size(472, 246);
            pnl_Register.Hide();
        }

        private void btn_RegisterConfirm_Click(object sender, EventArgs e)
        {
            //prep
            List<string> LicenceKey = new List<string>() { "XsZAb", "tgz3PsD", "qYh69un", "WQCEx" };
            bool LicenceError = true;
            bool PasswordsError = false;
            bool EmptyError = false;
            bool Isadmin = false;
            string email, password = null, passwordchecker1, passwordchecker2, licence;
            Login_DAO login = new Login_DAO();

            //getting the email
            email = txt_RegisterEmailAddress.Text;

            //checking if everything is filled in
            if (string.IsNullOrWhiteSpace(txt_RegisterUsername.Text) | string.IsNullOrWhiteSpace(txt_RegisterPassword.Text) | string.IsNullOrWhiteSpace(txt_RegisterConfirmPassword.Text) | string.IsNullOrWhiteSpace(txt_RegisterLicenceKey.Text) | string.IsNullOrWhiteSpace(txt_RegisterEmailAddress.Text))
            {
                EmptyError = true;
            }

            //checking the licence
            licence = txt_RegisterLicenceKey.Text;
            foreach (var key in LicenceKey)
            {
                if (licence == key)
                {
                    LicenceError = false;
                    break;
                }
            }

            //checking the password
            passwordchecker1 = txt_RegisterPassword.Text;
            passwordchecker2 = txt_RegisterConfirmPassword.Text;
            if (passwordchecker1 != passwordchecker2)
            {
                PasswordsError = true;
            }
            else
            {
                password = passwordchecker1;
            }

            //confirming if everything is ok
            if (EmptyError == true)
            {
                lbl_RegisterError.Show();
                lbl_RegisterError.Text = "Error! Fill in all requirements";
            }
            else if (LicenceError == true && PasswordsError == true)
            {
                lbl_RegisterError.Show();
                lbl_RegisterError.Text = "Error! Invalid licence key and unsimilar passwords";
            }
            else if (LicenceError == true)
            {
                lbl_RegisterError.Show();
                lbl_RegisterError.Text = "Error! Invalid licence key";
            }
            else if (PasswordsError == true)
            {
                lbl_RegisterError.Show();
                lbl_RegisterError.Text = "Error! Passwords does not match";
            }
            else
            {
                //MessageBox.Show($"email= {email}\npassword= {password}");
                login.AddAccount($"{email}", $"{password}");
                this.Hide();
                SomerenUI someren = new SomerenUI(Isadmin, $"{email}");
                someren.ShowDialog();
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password1 frm = new Password1();
            frm.ShowDialog();
        }
    }
}
