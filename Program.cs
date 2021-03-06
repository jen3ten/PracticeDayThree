﻿using System;
using System.Collections.Generic;

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

            // if myLetter is a, e, i, o, u then say its a vowel
            if(myLetter == 'a' || myLetter == 'e' || myLetter == 'i' || myLetter == 'o' || myLetter == 'u')
            {
                Console.WriteLine("This is a vowel");
            }
            else
            {
                Console.WriteLine("This is a consonent");
            }

            // use a List to save the vowels
            List<char> vowels = new List<char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');

            if (vowels.Contains(myLetter))
            {
                Console.WriteLine("This is a vowel, which I figured out by comparing to a list of vowels.");
            }
            else
            {
                Console.WriteLine("This is a consonent, because its not a vowel.");
            }

        }
    }
}
