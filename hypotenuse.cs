using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of the first side");
            int S1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side");
            int S2 = Convert.ToInt32(Console.ReadLine());
            double H = Math.Sqrt((S1 * S1) + (S2 * S2));
            Console.WriteLine("The value of the hypotenuse is " + H);
        }
    }
}
