using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name, location;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Location: ");
            location = Console.ReadLine();
            Console.WriteLine($"My name is {name}, " +
                $"I am from {location}");
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is " + today.ToString("d"));
            DateTime christmas = new DateTime(2022, 12, 25);
            TimeSpan daysUntilChristmas = christmas.Subtract(today);
            Console.WriteLine($"There are {daysUntilChristmas.Days} " +
                $"days left until christmas.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
