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
    class FoodDataAccess
    {
        public static List<FoodModel> LoadFoods()
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                var output = cnn.Query<FoodModel>("select * from Food", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void UpdateFood(FoodModel theater)
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                cnn.Execute("UPDATE Food " +
                            "SET Name = @Name, Price = @Price,Image = @Image " +
                            "WHERE FoodID = @FoodID",
                            theater);
            }
        }

        public static void SaveFood(FoodModel Food)
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                cnn.Execute("insert into Food (FoodID,Name,Price,Image) " +
                    "values(@FoodID,@Name,@Price,@Image)"
                    , Food);
            }
        }

        public static void DeleteFood(string FoodID)
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                string sqlcommand = "DELETE FROM Food WHERE FoodID = '" + FoodID + "'";
                cnn.Execute(sqlcommand);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
