using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a radius: ");
            double radius = double.Parse(Console.ReadLine());

            while (radius < 0)
            {
                Console.WriteLine("You have enter an invalid entry.  Please enter a positive number.");
                Console.Write("Please enter a positive entry for your radius: ");
                radius = double.Parse(Console.ReadLine());
            }


                double area = 3.14 * radius * radius;
                Console.WriteLine($"The area of your cirle is {area}.");
                Console.ReadLine();
            
            
        }
    }
}
