using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public partial class Password1 : Form
    {
        public Password1()
        {
            InitializeComponent();
            textBox_Answer.Hide();
            textBox_newA.Hide();
            textBox_newPassword.Hide();
            textBox_newQ.Hide();
            btn_Continue2.Hide();
            btn_Reset.Hide();
            label6.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            SomerenLogic.Login_Service loginService = new SomerenLogic.Login_Service();
            List<Login> loginList = loginService.GetLogin();

            //to know whether a username has been matched with one from the databse
            int count = 0;
            
            foreach (var u in loginList)
            {
                if (u.UserName == textBox_username.Text)
                {
                    lbl_SecretQuestion.Text = u.SecretQuestion;
                    count++;
                    break;
                }
            }

            if (count == 0)
            {
                lbl_SecretQuestion.Show();
                lbl_SecretQuestion.Text = "Wrong username!";
            }
            else
            {
                lbl_SecretQuestion.Show();
                btn_Continue.Hide();
                textBox_Answer.Show();
                btn_Continue2.Show();
            }
        }

        private void btn_Continue2_Click(object sender, EventArgs e)
        {
            SomerenLogic.Login_Service loginService = new SomerenLogic.Login_Service();
            List<Login> loginList = loginService.GetLogin();
            SomerenModel.Login login = new Login ();

            foreach (var u in loginList)
            {
                if (u.UserName == textBox_username.Text)
                {
                   login = u;
                    break;
                }
            }

            if (login.SecretAnswer == textBox_Answer.Text)
            {
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label9.Show();
                label8.Show();
                textBox_newPassword.Show();
                textBox_newQ.Show();
                textBox_newA.Show();
                btn_Reset.Show();
                btn_Continue2.Hide();
                label11.Show();
            }
            else
            {
                label2.Show();
            }
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            SomerenLogic.Login_Service loginService = new SomerenLogic.Login_Service();
            List<Login> loginList = loginService.GetLogin();
            SomerenModel.Login login = new Login();

            foreach (var u in loginList)
            {
                if (u.UserName == textBox_username.Text)
                {
                    login = u;
                    break;
                }
            }

            //The requirements state that there should be at least 1 uppercase letter, 1 lowercase letter and a punctuation mark
            if (textBox_newPassword.Text.Any(c => char.IsUpper(c)) && textBox_newPassword.Text.Any(c => char.IsLower(c)) && textBox_newPassword.Text.Any(c => char.IsPunctuation(c)) && textBox_newPassword.Text.Count() >= 8)
            {
                //create new DAO
                SomerenDAL.Login_DAO login_DAO = new SomerenDAL.Login_DAO();

                //check if both a secret question and answer is present, if only one is was added, do not reset password
                if (!string.IsNullOrEmpty(textBox_newQ.Text) && !string.IsNullOrEmpty(textBox_newA.Text))
                {
                    login_DAO.ChangeSecretA(textBox_newA.Text, login.UserName);
                    login_DAO.ChangeSecretQ(textBox_newQ.Text, login.UserName);
                }
                else if (string.IsNullOrEmpty(textBox_newQ.Text) && !string.IsNullOrEmpty(textBox_newA.Text))
                {
                    MessageBox.Show("Please fill in both the secret question and secret answer!");
                    return;
                }
                else if (!string.IsNullOrEmpty(textBox_newQ.Text) && string.IsNullOrEmpty(textBox_newA.Text))
                {
                    MessageBox.Show("Please fill in both the secret question and secret answer!");
                    return;
                }
                else
                {
                    label10.Show();
                }

                login_DAO.ChangePassword(textBox_newPassword.Text, textBox_username.Text);
                label7.Hide();
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                label7.Show();
            }
        }
    }
}
