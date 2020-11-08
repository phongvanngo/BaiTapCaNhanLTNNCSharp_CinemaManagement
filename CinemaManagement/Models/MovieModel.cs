using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.Models
{
    public class MovieModel
    {
        private string movieID;
        private string name;
        private int price;
        private string image;
        private string classify;
        private int time;

        //public MovieModel(string movieID, string name, int time, string classify, int price, string image)
        //{
        //    MovieID = movieID;
        //    Name = name;
        //    Time = time;
        //    Classify = classify;
        //    Price = price;
        //    Image = image;
        //}

        public string MovieID { get => movieID; set => movieID = value; }
        public string Name { get => name; set => name = value; }
        public int Time { get => time; set => time = value; }
        public string Classify { get => classify; set => classify = value; }
        public int Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
    }
}
