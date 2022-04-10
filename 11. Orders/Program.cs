using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //((daysInMonth * capsulesCount) * pricePerCapsule)
            int n = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                double priceForTheCoffe = 0;

                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                priceForTheCoffe += ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += priceForTheCoffe;
                Console.WriteLine($"The price for the coffee is: ${priceForTheCoffe:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
