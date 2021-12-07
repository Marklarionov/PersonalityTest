using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //the program asks the user to enthertheir favorite color
            //the programm displays the user's personality traits:
            //'red' - romantic, 'blue' - reliable, 'yellow' - cheerful
            //if the user enters anything else, the programm displays 
            //"you are a {userInput} unicorn."
            string color;
            Console.WriteLine("Enter your favorite color?");
            string color = Console.ReadLine().ToLower();
            if (color == "red")
            {
                Console.WriteLine("You are Romantic");
            }
            else if (color == "blue")
            {
                Console.WriteLine("You are Reliable");
            }
            else if (color == "yellow")
            {
                Console.WriteLine("Yu are cheerful");
            }
            else
            {
                Console.WriteLine("You are Unicorn");
            }
        }
    }
}
