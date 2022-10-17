using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double OUTFALL4 = 39.99;
            double CSOG = 15.99;
            double ZPLINTERzELL = 19.99;
            double HONORED2 = 59.99;
            double ROVERwATCH = 29.99;
            double ROVERwATCHoRIGINS = 39.99;

            double money = double.Parse(Console.ReadLine());
            string command = String.Empty;
            double spendMoney = 0;

            while ((command = Console.ReadLine()) != "Game Time")
            {
                
                switch (command)
                {
                    case "OutFall 4":
                        if (money >= OUTFALL4)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            money -= OUTFALL4;
                            spendMoney += OUTFALL4;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;

                    case "CS: OG":
                        if (money >= CSOG)
                        {
                            Console.WriteLine("Bought CS: OG");
                            money -= CSOG;
                            spendMoney += CSOG;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;

                    case "Zplinter Zell":
                        if (money >= ZPLINTERzELL)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            money -= ZPLINTERzELL;
                            spendMoney += ZPLINTERzELL;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;

                    case "Honored 2":
                        if (money >= HONORED2)
                        {
                            Console.WriteLine("Bought Honored 2");
                            money -= HONORED2;
                            spendMoney += HONORED2;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;

                    case "RoverWatch":
                        if (money >= ROVERwATCH)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            money -= ROVERwATCH;
                            spendMoney += ROVERwATCH;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (money >= ROVERwATCHoRIGINS)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            money -= ROVERwATCHoRIGINS;
                            spendMoney += ROVERwATCHoRIGINS;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }

            if (money > 0)
            {
                Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${money:f2}");
            }

        }
    }
}
