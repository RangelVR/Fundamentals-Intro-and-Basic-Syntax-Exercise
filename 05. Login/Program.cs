using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int numbersOfAttempts = 4;
            string reversedUserName = string.Empty;
            int counter = 4;

            for (int j = userName.Length - 1; j >= 0; j--)
            {
                reversedUserName += userName[j];
            }

            
            for (int i = 1; i <= numbersOfAttempts; i++)
            {
                
                string password = Console.ReadLine();
                counter--;

                if (password == reversedUserName)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (counter != 0)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                if (counter == 0)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

            }
        }
    }
}
