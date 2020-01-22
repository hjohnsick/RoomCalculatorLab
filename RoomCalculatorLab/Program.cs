using System;

namespace RoomCalculatorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput = 'y';

            while (userInput == 'y')
            {

                decimal area = 0.0m;
                decimal perimeter = 0.0m;
                decimal volume = 0.0m;

                Console.WriteLine("What is the length of the right side of the room?");
                decimal length = decimal.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of the room?");
                decimal width = decimal.Parse(Console.ReadLine());

                Console.WriteLine("What is the height of the room?");
                decimal height = decimal.Parse(Console.ReadLine());

                area = (length * width);
                Console.WriteLine($"The area of the room is: {area}");

                perimeter = ((length * 2) + (width * 2));
                Console.WriteLine($"The perimeter of the room is: {perimeter}");

                volume = (length * width * height);
                Console.WriteLine($"The volume of the room is: {volume}");

                Console.WriteLine("Do you have more rooms to measure? y/n");
                userInput= char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your measurements are all set.  Good Day!");

            Console.ReadKey();
        }

    }
}
