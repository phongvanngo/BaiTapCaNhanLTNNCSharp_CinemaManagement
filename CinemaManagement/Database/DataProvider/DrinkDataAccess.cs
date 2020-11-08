using CinemaManagement.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.Database.DataProvider
{
    class DrinkDataAccess
    {
        public static List<DrinkModel> LoadDrinks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DrinkModel>("select * from Drink", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void UpdateDrink(DrinkModel drink)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Drink " +
                            "SET Name = @Name, Price = @Price,Image = @Image " +
                            "WHERE DrinkID = @DrinkID",
                            drink);
            }
        }

        public static void SaveDrink(DrinkModel Drink)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Drink (DrinkID,Name,Price,Image) " +
                    "values(@DrinkID,@Name,@Price,@Image)"
                    , Drink);
            }
        }

        public static void DeleteDrink(string DrinkID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlcommand = "DELETE FROM Drink WHERE DrinkID = '" + DrinkID + "'";
                cnn.Execute(sqlcommand);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
