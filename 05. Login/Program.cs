using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }
            string password = Console.ReadLine();
            int count = 0;

            while (password != pass)
            {                
                count += 1;
                
                if (count > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                password = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
        
    }
}
