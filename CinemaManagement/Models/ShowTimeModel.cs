using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.Models
{
    public class ShowTimeModel
    {
        public string ShowTimeID { get; set; }
        public string TheaterID { get; set; }
        public string TheaterName { get; set; }
        public string TimeStart { get; set; }
        public string DateStart { get; set; }
        public string MovieID { get; set; }
        public string MovieName{ get; set; }
        public int RemainingSeats { get; set; }
    }
}
