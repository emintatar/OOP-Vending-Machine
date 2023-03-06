using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Products
    {
        public string name;
        public double price;

        public Products() 
        {
            Console.Write("Name: ");
            this.name = Console.ReadLine();

            Console.WriteLine("Price: ");
            this.price = Convert.ToDouble(Console.ReadLine());
        }

        public Products(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }
    }
}
