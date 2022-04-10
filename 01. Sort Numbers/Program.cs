using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = 3;
            List<int> numbers = new List<int>();

            for (int i = 0; i < countOfNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers.Add(n);
            }
            Console.WriteLine(string.Join(Environment.NewLine , numbers.OrderByDescending(x => x)));
            
        }
    }
}
