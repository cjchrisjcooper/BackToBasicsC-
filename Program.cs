using System;

namespace BackToBasicsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point pointOne = new Point(10, 10);
                Console.WriteLine("Distance to the point is: " + pointOne.DistanceTo(5, 5));

                Console.ReadLine();

            }
            catch (Exception ae) { Console.WriteLine("We caught an exception: " + ae.Message); }

        }
    }
}
