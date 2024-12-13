using System;

namespace ConsoleApp2
{
    internal class Program
    { 
        static void Main()
        {

            Console.Write("Enter the minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            // Calculate the number of minutes
            int hours = minutes / 60;
            minutes = minutes % 60;

            // Display the result
            Console.WriteLine("After conversion Houres:{0} and minutes:{1}", hours, minutes);
            Console.ReadKey();
        }
    }
}
