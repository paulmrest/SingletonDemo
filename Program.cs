using System;
using SingletonDemo.Classes;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iverson Observatory! The obvervatory where the answer is always yes but no, or no but yes.");
            Console.WriteLine();

            Console.WriteLine("First let's get a telescope instance...");
            TelescopeSingleton telescope = TelescopeSingleton.GetInstance();
            Console.WriteLine($"Our telescope's initial position is: {telescope}");
            Console.WriteLine();

            Console.WriteLine("Let's slew our telescope to right ascension 90 degrees, and declination 45 degrees.");
            telescope.Slew(90.0f, 45.0f);
            Console.WriteLine($"Our telescope's position is now: {telescope}");
            Console.WriteLine();

            Console.WriteLine("Next we'll get a \"separate\" (wink wink) instance of our telescope...");
            TelescopeSingleton telescopeAgain = TelescopeSingleton.GetInstance();
            Console.WriteLine($"Our \"new\" telescope has a position of: {telescopeAgain}");
        }
    }
}
