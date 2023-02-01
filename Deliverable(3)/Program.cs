/*
Author: Carlos M. Figueroa Palomino
Date: 1/31/2023
Description: C# console application that shows a series of odd or even numbers between 0 and the user's input.
*/

using System;

namespace Deliverable_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                string series = "";

                while (true)
                {
                    Console.Write("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.Write("Specify the series type, Even or Odd: ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "even" || series == "Odd" || series == "odd")
                    {
                        break;
                    }
                }

                if (series == "Odd" || series == "odd")
                {
                    Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 1; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "Even" || series == "even")
                {
                    Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                    for (int i = 0; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value.");
            }
        }
    }
}