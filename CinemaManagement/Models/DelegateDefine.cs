using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.Models
{
    public delegate void DataChangeDelegate();
    public delegate void AddItemInvoiceDelegate(string ID,string Name,int Price);
    public delegate void UserControlClickDelegate(object sender);
    public delegate void ChooseMovieDelegate(string MovieID);
}
