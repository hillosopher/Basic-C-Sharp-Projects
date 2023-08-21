using System;

namespace income_comparison
{
    class Program
    {

        // This Program takes as input the weekly hours worked and hourly rate for 2 people, calculates the annual salary for both people, than
        // compares the two annual salaries to confirm who makes more in a boolean comparison. 
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1, what is your hourly rate?");
            string rate1 = Console.ReadLine();
            byte hourlyRate1 = byte.Parse(rate1);
            Console.WriteLine("Person 1, how many hours do you work a week?");
            string hours1 = Console.ReadLine();
            byte weeklyHours1 = byte.Parse(hours1);
            Console.WriteLine("Person 2, what is your hourly rate?");
            string rate2 = Console.ReadLine();
            byte hourlyRate2 = byte.Parse(rate2);
            Console.WriteLine("Person 2, how many hours do you work a week?");
            string hours2 = Console.ReadLine();
            byte weeklyHours2 = byte.Parse(hours2);
            int salary1 = hourlyRate1 * weeklyHours1 * 52;
            int salary2 = hourlyRate2 * weeklyHours2 * 52;
            bool comp = salary1 > salary2;
            Console.WriteLine("Annual Salary of Person 1: " + salary1);
            Console.WriteLine("Annual Salary of Person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + comp);
            Console.ReadLine();
        }
    }
}
