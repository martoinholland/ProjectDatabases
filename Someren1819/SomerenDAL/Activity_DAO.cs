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
    public class Activity_DAO : Base
    {
        public void ActivityAdder(int id, string description, int nOfStudents, int nOfSupervisors)
        {
            string constring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Activity (activityID, Description, numberOfStudents, numberOfSupervisors) VALUES (@id, @description, @nOfStudents, @nOfsupervisors)", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@nOfStudents", nOfStudents);
                    cmd.Parameters.AddWithValue("@nOfSupervisors", nOfSupervisors);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void ActivityRemover(int id)
        {
            string query = $"DELETE FROM Activity WHERE activityID = {id}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ActivityChanger(int id, string description, int nOfStudents, int nOfsupervisors)
        {
            string query = $"UPDATE Activity SET Description = '{description}', numberOfStudents = {nOfStudents}, numberOfSupervisors = {nOfsupervisors} WHERE activityID = {id} ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Activity> Db_Get_All_Activity()
        {
            string query = "SELECT activityID, Description, numberOfStudents, numberOfSupervisors FROM Activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        //activityID, Description, numberOfStudents, numberOfSupervisors

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activity = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity act = new Activity()
                {
                    ActivityID = (int)dr["activityID"],
                    Description = (String)(dr["Description"].ToString()),
                    NumberOfStudents = (int)dr["numberOfStudents"],
                    NumberOfSupervisors = (int)dr["numberOfSupervisors"]
                };
                activity.Add(act);
            }
            return activity;
        }
    }
}
