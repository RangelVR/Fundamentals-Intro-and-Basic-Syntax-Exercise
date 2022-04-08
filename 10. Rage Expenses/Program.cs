using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;

            double totalHeadsetPrice = (lostGamesCount / 2) * headsetPrice;
            double totalMousePrice = (lostGamesCount / 3) * mousePrice;
            double totalKeyboardPrice = (lostGamesCount / 6) * keyboardPrice;
            double totalDisplayPrice = (lostGamesCount / 12) * displayPrice;

            if (lostGamesCount >= 12)
            {
                rageExpenses = totalHeadsetPrice + totalMousePrice + totalKeyboardPrice + totalDisplayPrice;
            }
            else if (lostGamesCount < 12 && totalKeyboardPrice > 3)
            {
                rageExpenses = totalHeadsetPrice + totalMousePrice + totalKeyboardPrice;
                
            }
            else if (lostGamesCount == 3)
            {
                rageExpenses = totalHeadsetPrice + totalMousePrice;
            }
            else if (lostGamesCount == 2)
            {
                rageExpenses = totalHeadsetPrice;
            }

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");

        }
    }
}
