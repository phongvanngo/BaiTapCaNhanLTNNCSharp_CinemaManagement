using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.Model
{
    public class MovieModel
    {
        private string movieID;
        private string name;
        private string price;
        private string image;
        private string label;
        private int time;

        public MovieModel(string movieID, string name,int time, string label, string price, string image)
        {
            this.movieID = movieID;
            this.name = name;
            this.price = price;
            this.image = image;
            this.label = label;
            this.time = time;
        }

        public string MovieID { get => movieID; set => movieID = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public string Label { get => label; set => label = value; }
        public int Time { get => time; set => time = value; }
    }
}
