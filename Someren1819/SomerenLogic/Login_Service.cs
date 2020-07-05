using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SomerenLogic
{
    public class Login_Service
    {
        Login_DAO login_db = new Login_DAO();

        public List<Login> GetLogin()
        {
            try
            {
                List<Login> login = login_db.Db_Login();
                return login;
            }
            catch (SqlException)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
