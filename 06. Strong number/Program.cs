using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int currNum = 0;

            int isStrongNum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                currNum = num[i] - '0';

                int factoriel = 1;
                for (int j = 1; j <= currNum; j++)
                {
                    factoriel *= j;
                }
                isStrongNum += factoriel;
            }
            if (isStrongNum == int.Parse(num))
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
