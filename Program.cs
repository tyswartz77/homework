using System;

namespace Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int S1 = 3;
            int S2 = 4;
            double H = Math.Sqrt((S1 * S1) + (S2 * S2));
            Console.WriteLine("The value of the hypotenuse is " + H);
        }
    }
}
