using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double finalPriceLightsabers = Math.Ceiling(students * 1.1) * priceOfLightsabers;
            double finalPriceRobes = priceOfRobes * students;

            double sum = 0;
            if (students >= 6)
            {
                int freeBelts = students / 6;
                sum = finalPriceLightsabers + finalPriceRobes + (priceOfBelts * (students - freeBelts));
            }
            else
            {
                sum = finalPriceLightsabers + finalPriceRobes + (priceOfBelts * students);
            }

            if (sum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                double neededMoney = sum - money;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
