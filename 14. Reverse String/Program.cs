using System;

namespace _14._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversedInput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseInput += input[i];
            }
            Console.WriteLine(reverseInput);
        }
    }
}
