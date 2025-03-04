using System;

namespace BackToBasicsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Map map = new Map(10, 10);
                Path path = new Path(
                    new[]
                    {
                    new MapLocation(0,1, map),
                    new MapLocation(1,1, map),
                    new MapLocation(2,1, map),
                    new MapLocation(3,1, map),
                    new MapLocation(4,1, map),
                    new MapLocation(5,1, map),
                    new MapLocation(6,1, map),
                    new MapLocation(7,1, map),
                    }
                    );

                MapLocation thirdLocation = path.getLocationAt(2);
                Console.WriteLine(thirdLocation.X + "," + thirdLocation.Y);
                Console.ReadLine();
            }
            catch (Exception ae) { Console.WriteLine("We caught an exception: " + ae.Message); }

        }
    }
}
