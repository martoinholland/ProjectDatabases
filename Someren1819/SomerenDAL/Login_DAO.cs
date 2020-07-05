using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SomerenDAL
{
    public class Login_DAO : Base
    {
        public List<Login> Db_Login()
        {
            string query = "SELECT [user], [password], [type], [adminRequest], [requestDenied], [secretQuestion], [secretAnswer] FROM LoginTable";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> login = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {                               
                Login logn = new Login()
                {
                    UserName = (string)dr["user"],
                    Password = (string)dr["password"],
                    Type = (string)dr["type"],
                    AdminRequest = (bool)dr["adminRequest"],
                    RequestDenied = (bool)dr["requestDenied"],
                    SecretQuestion = (string)dr["secretQuestion"],
                    SecretAnswer = (string)dr["secretAnswer"]
                };
                login.Add(logn);
            }
            return login;
        }

        //registering an account
        public void AddAccount(string email, string password)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[LoginTable] ([user], password, type, secretQuestion, secretAnswer, adminRequest, requestDenied) VALUES ('"+email+"', '"+password+"', 'user', NULL, NULL, 0, 0);", con))
                {
                    cmd.CommandType = CommandType.Text;
                    int affected = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        //promoting an account
        public void PromoteAccount(string email)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE LoginTable SET [type] = 'admin', [adminRequest] = 0, [requestDenied] = 0 WHERE [user] = '"+email+"'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    int affected = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        //sending admin request
        public void RequestAdmin(string email)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE LoginTable SET [adminRequest] = 1 WHERE [user] = '"+email+"'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    int affected = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        //determining admin request
        public void AnswerRequest(bool answer, string email)
        {
            int bit = 0;
            if (answer == true)
            {
                bit = 1;
            }
            else if (answer == false)
            {
                bit = 0;
            }

            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE LoginTable SET [requestDenied] = "+bit+" WHERE [user] = '"+email+"'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    int affected = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }


        public void ChangePassword(string password, string id)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [dbo].[LoginTable] SET password = @password WHERE [user] = @id", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void ChangeSecretQ(string secretQ, string id)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [dbo].[LoginTable] SET secretQuestion = @secretQ WHERE [user] = @id", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@secretQ", secretQ);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void ChangeSecretA(string secretA, string id)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [dbo].[LoginTable] SET secretAnswer = @secretA WHERE [user] = @id", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@secretA", secretA);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
