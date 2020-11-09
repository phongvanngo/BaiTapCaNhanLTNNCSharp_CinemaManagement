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
using System.Windows;

namespace CinemaManagement.Database.DataProvider
{
    class ShowTimeDataAccess
    {
        public static List<ShowTimeModel> LoadShowTimes()
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                var output = cnn.Query<ShowTimeModel>("select * from ShowTime", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void UpdateShowTime(ShowTimeModel showtime)
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                cnn.Execute("UPDATE showtime " +
                            "SET MovieID = @MovieID, RemainingSeats = @RemainingSeats, TheaterID = @TheaterID, DateStart = @DateStart, TimeStart = @TimeStart " +
                            "WHERE ShowTimeID = @ShowTimeID",
                            showtime);
            }
        }

        public static void SaveShowTime(ShowTimeModel showtime)
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                cnn.Execute("insert into ShowTime (ShowTimeID,TheaterID,MovieID,TimeStart,DateStart,RemainingSeats) " +
                    "values(@ShowTimeID,@TheaterID,@MovieID,@TimeStart,@DateStart,@RemainingSeats)"
                    , showtime);
            }
        }

        public static void DeleteShowTime(string ShowTimeID)
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                string sqlcommand = "DELETE FROM ShowTime WHERE ShowTimeID = '" + ShowTimeID + "'";
                cnn.Execute(sqlcommand);
            }
        }

        public static bool CheckValidNewShowTime(ShowTimeModel showtime)
        {
            using (IDbConnection cnn = new SQLiteConnection(BaseDataProvider.LoadConnectionString()))
            {
                string sqlcommand =
                    "select * from ShowTime " +
                    "WHERE " +
                    $"MovieID = '{showtime.MovieID}' and " +
                    $"TheaterID = '{showtime.TheaterID}' and " +
                    $"DateStart = '{showtime.DateStart}' and " +
                    $"TimeStart = '{showtime.TimeStart}'";
                var output = cnn.Query<ShowTimeModel>(sqlcommand,new DynamicParameters());
                if (output.ToList().Count == 0) return true; else return false;
                
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
