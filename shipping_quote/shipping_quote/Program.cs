using System;
using System.Threading;

namespace shipping_quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n\nWhat is your package's weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Thread.Sleep(3000);
            } else
            {
                Console.WriteLine("What's your package's width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What's your package's height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What's your package's length?");
                int length = Convert.ToInt32(Console.ReadLine());
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Thread.Sleep(3000);
                } else
                {
                    float cost = width * height * length * weight / 100.00f;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + cost + "\nThank you!");
                }
            }
        }
    }
}
