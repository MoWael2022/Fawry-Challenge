using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }
        public DateOnly DataOfBuy { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public int DayOfStore { get; set; }
    }
    
}
