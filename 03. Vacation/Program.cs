using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;

            if (day == "Friday")
            {
                double studentsPrice = 8.45;
                double businessPrice = 10.90;
                double regularPrice = 15.00;

                if (type == "Students")
                {
                    if (countOfPeople >= 30)
                    {
                        totalPrice = (studentsPrice * countOfPeople) * 0.85;
                    }
                    else
                    {
                        totalPrice = studentsPrice * countOfPeople;
                    }
                    
                }
                else if (type == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                        totalPrice = countOfPeople * businessPrice;
                    }
                    else
                    {
                        totalPrice = countOfPeople * businessPrice;
                    }
                    
                }
                else if (type == "Regular")
                {
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice = (countOfPeople * regularPrice) * 0.95;
                    }
                    else
                    {
                        totalPrice = countOfPeople * regularPrice;
                    }
                    
                }

            }
            else if (day == "Saturday")
            {
                double studentsPrice = 9.80;
                double businessPrice = 15.60;
                double regularPrice = 20.00;

                if (type == "Students")
                {
                    if (countOfPeople >= 30)
                    {
                        totalPrice = (studentsPrice * countOfPeople) * 0.85;
                    }
                    else
                    {
                        totalPrice = studentsPrice * countOfPeople;
                    }
                    
                }
                else if (type == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                        totalPrice = countOfPeople * businessPrice;
                    }
                    else
                    {
                        totalPrice = countOfPeople * businessPrice;
                    }
                    
                }
                else if (type == "Regular")
                {
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice = (countOfPeople * regularPrice) * 0.95;
                    }
                    else
                    {
                        totalPrice = countOfPeople * regularPrice;
                    }
                    
                }
            }
            else if (day == "Sunday")
            {
                double studentsPrice = 10.46;
                double businessPrice = 16.00;
                double regularPrice = 22.50;

                if (type == "Students")
                {
                    if (countOfPeople >= 30)
                    {
                        totalPrice = (studentsPrice * countOfPeople) * 0.85;
                    }
                    else
                    {
                        totalPrice = studentsPrice * countOfPeople;
                    }
                    
                }
                else if (type == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                        totalPrice = countOfPeople * businessPrice;
                    }
                    else
                    {
                        totalPrice = countOfPeople * businessPrice;
                    }
                    
                }
                else if (type == "Regular")
                {
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice = (countOfPeople * regularPrice) * 0.95;
                    }
                    else
                    {
                        totalPrice = countOfPeople * regularPrice;
                    }
                    
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
