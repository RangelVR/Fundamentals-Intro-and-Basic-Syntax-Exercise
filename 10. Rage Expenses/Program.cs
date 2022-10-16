using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;

            for (int i = 2; i <= lostGames; i++)
            {
                if (i % 12 == 0)
                {
                    rageExpenses += headsetPrice + mousePrice + keyboardPrice + displayPrice;
                }
                else if (i % 6 == 0)
                {
                    rageExpenses += headsetPrice + mousePrice + keyboardPrice;
                }
                else if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
                else if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
