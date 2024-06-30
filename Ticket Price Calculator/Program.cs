using System;

namespace MovieTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            decimal ticketPrice;
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00m;
                Console.WriteLine($"As a senior citizen/child, your ticket price is GHC{ticketPrice:F2}.");
            }
            else
            {
                ticketPrice = 10.00m;
                Console.WriteLine($"Your ticket price is GHC{ticketPrice:F2}.");
            }

            Console.ReadLine();
        }
    }
}