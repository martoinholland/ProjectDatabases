using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Drinks_Service
    {
        Drinks_DAO drinks_db = new Drinks_DAO();

        public List<Drinks> GetDrinks()
        {
            try
            {
                List<Drinks> drinks = drinks_db.Db_Get_All_Drinks();
                return drinks;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
