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
    public class Drinks_DAO : Base
    {
        public List<Drinks> Db_Get_All_Drinks()
        {
            string query = "SELECT drinkName, price, stock, drinkSold " +
                            "FROM Drinks " +
                            "WHERE price > 1 AND stock > 1 " +
                            "ORDER BY stock, price, drinkSold";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string name = dr["DrinkName"].ToString();

                if (name == "Water" || name == "Orangeade" || name == "Cherry juice")
                {
                    continue;
                }
                Drinks drink = new Drinks()
                {
                    DrinkName = name,
                    Price = (decimal)dr["price"],
                    Stock = (int)dr["stock"],
                    DrinkSold = (int)dr["drinkSold"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
