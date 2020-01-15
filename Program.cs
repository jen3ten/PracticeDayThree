using System;

namespace PracticeDayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a console application to check whether a letter is a vowel or consonant. 
            // Hint: You can do this problem using a switch or an if condition.

            Console.Write("Enter a letter: ");

            string userInput = Console.ReadLine();
            char myLetter = Convert.ToChar(userInput);
            // char myLetter = Convert.ToChar(Console.ReadLine());

        }
    }
}
