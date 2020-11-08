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
    class MovieDataAccess
    {
        public static List<MovieModel> LoadMovies()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MovieModel>("select * from Movie", new DynamicParameters());
                //MessageBox.Show((ou as MovieModel).FirstName);
                return output.ToList();
            }
        }

        public static void UpdateMovies(MovieModel movie)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE movie " +
                            "SET Name = @Name, Time = @Time, Classify = @Classify, Price = @Price, Image = @Image " +
                            "WHERE MovieID = @MovieID",
                            movie);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
