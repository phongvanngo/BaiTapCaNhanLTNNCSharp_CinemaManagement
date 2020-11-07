using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CinemaManagement.Model;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace CinemaManagement.Database
{
    public static class DataProvider
    {
        public static List<MovieModel> LoadMovies()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MovieModel>("select * from Movie", new DynamicParameters());
                return output.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
