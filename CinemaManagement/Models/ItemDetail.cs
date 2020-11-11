using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.Models
{
    public class ItemDetail
    {
        string iD;
        string name;
        string amount;
        string price;
        string total;

        public ItemDetail(string iD, string name, string amount, string price, string total)
        {
            ID = iD;
            Name = name;
            Amount = amount;
            Price = price;
            Total = total;
        }

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Amount { get => amount; set => amount = value; }
        public string Price { get => price; set => price = value; }
        public string Total { get => total; set => total = value; }
    }
    
}
