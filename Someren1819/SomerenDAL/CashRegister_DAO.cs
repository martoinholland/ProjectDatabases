using SomerenModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class CashRegister_DAO : Base
    {
        public void CashAdder(string studentName, string drinkName)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO CashRegister (StudentName, DrinkName) VALUES (@studentName, @drinkName)", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@studentName", studentName);
                    cmd.Parameters.AddWithValue("@drinkName", drinkName);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }               
            }
        } 
        public List<Register> Db_Get_All_CashRegister()
        {
            string query = "SELECT StudentName, DrinkName FROM CashRegister";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Register> ReadTables(DataTable dataTable)
        {
            List<Register> register = new List<Register>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Register re = new Register()
                {
                    StudentName = (string)dr["StudentName"],
                    DrinkName = (String)(dr["DrinkName"].ToString())
                };
                register.Add(re);
            }
            return register;
        }
    }
}
