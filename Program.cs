using System;

namespace BackToBasicsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new Point(10, 10);
            Console.WriteLine("Distance to the point is: " + pointOne.DistanceTo(5, 5));

            Console.ReadLine();
        }
    }
}
