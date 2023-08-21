using System;

namespace insurance_qualification
{
    class Program
    {
        static void Main()
        {   // Gather information from user
            Console.WriteLine("Car Insurance Qualification check\n\nWhat is your age?");
            string ageStr = Console.ReadLine();
            byte age = byte.Parse(ageStr);
            Console.WriteLine("Have you ever had a DUI? Please type 'yes' or 'no'.");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string tix = Console.ReadLine();
            byte tickets = byte.Parse(tix);

            // Boolean operation
            bool qualified = age > 15 && dui == "no" && tickets < 4;

            // final output
            Console.WriteLine("Qualified?\n" + qualified);
        }
    }
}
