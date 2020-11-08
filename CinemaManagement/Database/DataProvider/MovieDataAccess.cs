﻿using CinemaManagement.Models;
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

        public static void UpdateMovie(MovieModel movie)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE movie " +
                            "SET Name = @Name, Time = @Time, Classify = @Classify, Price = @Price, Image = @Image " +
                            "WHERE MovieID = @MovieID",
                            movie);
            }
        }

        public static void SaveMovie(MovieModel movie)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Movie (MovieID,Name,Price,Image,Time,Classify) " +
                    "values(@MovieID,@Name,@Price,@Image,@Time,@Classify)"
                    , movie);
            }
        }        
        
        public static void DeleteMovie(string MovieID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //MessageBox.Show(string.Format(@"DELETE FROM Movie WHERE MovieID = {0}", MovieID));
                string sqlcommnad = "DELETE FROM Movie WHERE MovieID = '" + MovieID + "'";
                cnn.Execute(sqlcommnad);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
