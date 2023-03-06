namespace VendingMachine
{
    class Program
    {
        static int letterCounter = 0;

        static void printProducts(Products[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("ID: " + (letterCounter ));
                Console.WriteLine(products[i].getName());
                Console.WriteLine(products[i].getPrice() + " TL");
                Console.WriteLine();
                letterCounter++;
            }
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Machine machine = new Machine();
            int selectedID;
            double money, change;

            Console.WriteLine("Welcome to Vending Machine!");
            Console.WriteLine();
            printProducts(machine.getProducts());

            Console.Write("Enter product ID: ");
            selectedID = int.Parse(Console.ReadLine());

            Products[] products = machine.getProducts();

            if ((selectedID > products.Count()) || (selectedID < 0))
            {
                Console.WriteLine("Invalid ID!");
            }

            else
            {
                try
                {
                    Console.Write("Enter money: ");
                    money = Convert.ToDouble(Console.ReadLine());

                    if (money < products[selectedID].getPrice())
                    {
                        Console.WriteLine("Insufficient money!");
                    }

                    else
                    {
                        change = calculator.calculateChange(money, selectedID);
                        Console.WriteLine("Please take your product.");
                        Console.WriteLine("Change: " + change);
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }
}