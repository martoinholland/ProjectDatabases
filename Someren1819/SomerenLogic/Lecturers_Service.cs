using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Lecturers_Service
    {
        Lecturers_DAO lecturers_db = new Lecturers_DAO();

        public List<Teacher> GetLecturers()
        {
            try
            {
                List<Teacher> lecturer = lecturers_db.Db_Get_All_Lecturers();
                return lecturer;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
