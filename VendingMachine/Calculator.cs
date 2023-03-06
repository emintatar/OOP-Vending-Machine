using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Calculator
    {
        Machine machine = new Machine();

        public double calculateChange(double money, int selectedID)
        {
            Products[] products = machine.getProducts();
            double expense = products[selectedID].getPrice();

            return money - expense;
        }
    }
}
