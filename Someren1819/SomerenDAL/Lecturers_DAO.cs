using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class Lecturers_DAO : Base
    {

        public List<Teacher> Db_Get_All_Lecturers()
        {
            string query = "SELECT teacher_id, name FROM TEACHER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> lecturers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher lecturer = new Teacher()
                {
                    Number = (int)dr["teacher_id"],
                    Name = (String)(dr["name"].ToString())
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }

    }
}

