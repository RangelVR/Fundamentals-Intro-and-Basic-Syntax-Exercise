using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            string coins = Console.ReadLine();
            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;
            double sum = 0;

            while (coins != "Start")
            {
                if (coins == "0.1" || coins == "0.2" || coins == "0.5"
                    || coins == "1" || coins == "2")
                {
                    double money = double.Parse(coins);
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                coins = Console.ReadLine();
            }

            string product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sum >= nutsPrice)
                        {
                            sum -= nutsPrice;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum >= waterPrice)
                        {
                            sum -= waterPrice;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sum >= crispsPrice)
                        {
                            sum -= crispsPrice;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sum >= sodaPrice)
                        {
                            sum -= sodaPrice;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum >= cokePrice)
                        {
                            sum -= cokePrice;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                    
                }
                
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
