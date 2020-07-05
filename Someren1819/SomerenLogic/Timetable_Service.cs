using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Timetable_Service
    {
        Timetable_DAO Timetable_db = new Timetable_DAO();

        public List<Timetable> GetTimetables()
        {
            try
            {
                List<Timetable> timetable = Timetable_db.Db_Get_All_Timetable();
                return timetable;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
