using System;

namespace ConsoleApp6
{
    internal class ConvertValues
    {
        public void KilometerToMeter()
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double meters = kilometers * 1000;
            Console.WriteLine("The distance in meters is: " + meters);
            Console.ReadKey();
        }
    }
}
