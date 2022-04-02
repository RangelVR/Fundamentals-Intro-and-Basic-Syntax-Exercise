using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string isStrongNumber = Console.ReadLine();
            int num = 0;
            int sumFactorial = 0;
            int factorial = 1;

            for (int i = 0; i < isStrongNumber.Length; i++)
            {
                num = isStrongNumber[i] - '0';
                for (int k = 1; k <= num; k++)
                {
                    factorial *= k;
                }
                sumFactorial += factorial;
                factorial = 1;
            }
            string strongNum = sumFactorial.ToString();

            if (strongNum == isStrongNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
