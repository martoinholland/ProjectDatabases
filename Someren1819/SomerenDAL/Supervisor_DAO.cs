using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Configuration;

namespace SomerenDAL
{
    public class Supervisor_DAO : Base
    {
        public List<Supervisor> Db_Get_All_Supervisors()
        {
            string query = "SELECT Supervisor.LecturerID, TEACHER.name " +
                "FROM Supervisor " +
                "Join TEACHER " +
                "ON Supervisor.LecturerID = TEACHER.teacher_id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor()
                {
                    LecturerID = (int)dr["LecturerID"],
                    name = (String)dr["name"]
                };
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        public void SupervisorAdd(string id)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Supervisor] (LecturerID) VALUES (@id)", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void SupervisorRemove(string id)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE from [dbo].[Supervisor] WHERE LecturerID = @id", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
