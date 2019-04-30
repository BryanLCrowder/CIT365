using System;

namespace ConsoleAppliation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Name and location.
            string fullName = "Bryan Crowder";
            string location = "Rexburg, Idaho 83440";

            //Days to Christmas.
            var today = DateTime.Now;
            var christmas = new DateTime(today.Year, 12, 25);
            var subtract = christmas - today;

            //Print to the user.
            Console.WriteLine("My name is: " + fullName + "and my location is " + location);
            Console.WriteLine("The Current date is: " + today.ToString("yyyy/MM/dd"));
            Console.WriteLine("There are " + subtract.ToString("dd") + " days until Christmas.");

            //The code from the book.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
                   woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                   glassArea + " square metres");
        }
    }
}
