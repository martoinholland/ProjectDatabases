using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Supervisor_Service
    {
        Supervisor_DAO supervisors_db = new Supervisor_DAO();

        public List<Supervisor> GetSupervisors()
        {
            try
            {
                List<Supervisor> supervisor = supervisors_db.Db_Get_All_Supervisors();
                return supervisor;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
