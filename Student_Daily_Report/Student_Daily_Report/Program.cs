using System;

namespace Student_Daily_Report
{
    class Program
    {
        //This simple console program collects data from students about their current progress in their course, asking for their feedback and if they need help. The program is
        // only a model and does not actually save the data. 
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            short pageNum = short.Parse(page);
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string help = Console.ReadLine();
            bool helpConv = bool.Parse(help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string study = Console.ReadLine();
            byte hours = byte.Parse(study);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
