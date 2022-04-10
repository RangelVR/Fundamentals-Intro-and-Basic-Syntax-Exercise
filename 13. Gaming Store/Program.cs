using System;

namespace _13._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currBalance = double.Parse(Console.ReadLine());
            
            double outFallPrice = 39.99;
            double csPricePrice = 15.99;
            double zplinterPrice = 19.99;
            double honoredPrice = 59.99;
            double roverWatchPrice = 29.99;
            double roverWatchOrEdPrice = 39.99;
            
            string gameName = Console.ReadLine();
            
            double totalSpend = 0;

            while (gameName != "Game Time")
            {
                
                switch (gameName)
                {
                    case "OutFall 4":
                        if (outFallPrice > currBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        currBalance -= outFallPrice;
                        totalSpend += outFallPrice;
                        Console.WriteLine("Bought OutFall 4");
                        break;

                    case "CS: OG":
                        if (csPricePrice > currBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        currBalance -= csPricePrice;
                        totalSpend += csPricePrice;
                        Console.WriteLine("Bought CS: OG");
                        break;

                    case "Zplinter Zell":
                        if (zplinterPrice > currBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        currBalance -= zplinterPrice;
                        totalSpend += zplinterPrice;
                        Console.WriteLine("Bought Zplinter Zell");
                        break;

                    case "Honored 2":
                        if (honoredPrice > currBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        currBalance -= honoredPrice;
                        totalSpend += honoredPrice;
                        Console.WriteLine("Bought Honored 2");
                        break;

                    case "RoverWatch":
                        if (roverWatchPrice > currBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        currBalance -= roverWatchPrice;
                        totalSpend += roverWatchPrice;
                        Console.WriteLine("Bought RoverWatch");
                        break;

                    case "RoverWatch Origins Edition":
                        if (roverWatchOrEdPrice > currBalance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        currBalance -= roverWatchOrEdPrice;
                        totalSpend += roverWatchOrEdPrice;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                gameName = Console.ReadLine();
                
            }

            if (currBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${currBalance:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
            
        }
    }
}
