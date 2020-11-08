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
    class TheaterDataAccess
    {
        public static List<TheaterModel> LoadTheaters()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TheaterModel>("select * from Theater", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void UpdateTheater(TheaterModel theater)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE theater " +
                            "SET Name = @Name, Seats = @Seats " +
                            "WHERE TheaterID = @TheaterID",
                            theater);
            }
        }

        public static void SaveTheater(TheaterModel theater)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Theater (TheaterID,Name,Seats) " +
                    "values(@TheaterID,@Name,@Seats)"
                    , theater);
            }
        }

        public static void DeleteTheater(string TheaterID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlcommnad = "DELETE FROM Theater WHERE TheaterID = '" + TheaterID + "'";
                cnn.Execute(sqlcommnad);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
