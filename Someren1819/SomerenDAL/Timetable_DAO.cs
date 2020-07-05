using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Timetable_DAO : Base
    {
        public List<Timetable> Db_Get_All_Timetable()
        {
            string query = "SELECT date_id, activities, supervisors, date, starttime, endtime FROM Timetable";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Timetable> ReadTables(DataTable dataTable)
        {
            List<Timetable> timetables = new List<Timetable>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Timetable timetable = new Timetable()
                {
                    Date_Id = (int)dr["date_id"],
                    Activity = (String)(dr["activities"].ToString()),
                    Supervisor = (String)(dr["supervisors"].ToString()),
                    Date = (DateTime)dr["date"],
                    Startime = (String)(dr["starttime"].ToString()),
                    Endtime = (String)(dr["endtime"].ToString())
                };
                timetables.Add(timetable);
            }
            return timetables;
        }
    }
}