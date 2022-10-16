using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            
            double totalPrice = 0;

            for (int i = 0; i < orders; i++)
            {
                double priceOrder = 0;
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                priceOrder = pricePerCapsule * days * capsulesCount;
                totalPrice += priceOrder;
                Console.WriteLine($"The price for the coffee is: ${priceOrder:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
