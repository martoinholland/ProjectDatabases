using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class SomerenDAL
    {
        CashRegister_DAO register_db = new CashRegister_DAO();

        public List<Register> GetRegister()
        {
            try
            {
                List<Register> register = register_db.Db_Get_All_CashRegister();
                return register;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
