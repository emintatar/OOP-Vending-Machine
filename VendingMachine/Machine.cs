using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Machine
    {
        private Products p1 = new Products("Caramio", 3.86);
        private Products p2 = new Products("Albeni", 5.0);
        private Products p3 = new Products("Xroll Bar", 2.95);
        private Products p4 = new Products("Metro", 3.50);
        private Products p5 = new Products("Çokofest", 10.0);

        Products[] products;

        public Machine()
        {
            products = new Products[] { p1, p2, p3, p4, p5 };
        }

        public Products[] getProducts()
        {
            return products;
        }
    }
}
