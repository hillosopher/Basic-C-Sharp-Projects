using System;

namespace console_math
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gimme a numba and I'll give ya some maths!");
            string str1 = Console.ReadLine();
            double num1 = double.Parse(str1);
            double res1 = num1 * 50;
            Console.WriteLine("I just multiplied your number by 50 and got " + res1 + "\n\nGimme another numba and I'll do some more maths!");
            string str2 = Console.ReadLine();
            double num2 = double.Parse(str2);
            double res2 = num2 + 25;
            Console.WriteLine("I just added 25 to your number and got " + res2 + "\n\nGimme another numba and I'll do some more maths!");
            string str3 = Console.ReadLine();
            float num3 = float.Parse(str3);
            float res3 = num3 / 12.5f;
            Console.WriteLine("I just divided your number by 12.5 and got " + res3 + "\n\nGimme another numba and I'll do some more maths!");
            string str4 = Console.ReadLine();
            double num4 = double.Parse(str4);
            bool res4 = num4 > 50;
            Console.WriteLine("I just checked if your number was greater than 50 and that is " + res4.ToString() + "\n\nGimme another numba and I'll do my last maths!");
            string str5 = Console.ReadLine();
            double num5 = double.Parse(str5);
            double res5 = num5 % 7.0;
            Console.WriteLine("I just divided your number by 7. The remainder is " + res5 + "\n\nThanks for doing all these maths with me.");
            Console.ReadLine();
        }
    }
}
