using System;

namespace BackToBasicsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cans of meat would you like to order:");
            string cansOrderedAsText = Console.ReadLine();
            int cansOrdered = Int32.Parse(cansOrderedAsText);
            Console.WriteLine(cansOrdered);
            Console.ReadLine();

        }
    }
}
