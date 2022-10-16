using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.MinValue;
            int n2 = int.MinValue;
            int n3 = int.MinValue;

            for (int i = 0; i < 3; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());

                if (inputNum > n1)
                {
                    n3 = n2;
                    n2 = n1;
                    n1 = inputNum;
                }
                else if (inputNum > n2)
                {
                    n3 = n2;
                    n2 = inputNum;
                }
                else if (inputNum > n3)
                {
                    n3 = inputNum;
                }
            }
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
