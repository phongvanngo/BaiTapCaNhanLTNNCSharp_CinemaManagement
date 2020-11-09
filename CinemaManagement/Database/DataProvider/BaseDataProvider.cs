using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CinemaManagement.Database.DataProvider
{
    class BaseDataProvider
    {
        public static string LoadConnectionString()
        {
            //lấy database ko phải trong thư mục debug
            var CurrentDirectory = System.Environment.CurrentDirectory;
            string CurrentProjectD = Directory.GetParent(CurrentDirectory).Parent.FullName;
            return (@"Data Source=" + CurrentProjectD + @"\Database\CinemaManagerDatabase.db");
        }
    }
}
