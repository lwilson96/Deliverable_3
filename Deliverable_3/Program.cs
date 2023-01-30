/*
Author: Lee Wilson
Date: 1/29/2023
Description: C# Console Application for Listing odd and even numbers in
in a selected range.
*/

using System;
using System.Linq.Expressions;

namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Boolean done = false;

            while (true)
            {
                Console.WriteLine("Enter an integer number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());
                
                if (input >= 1 && input <= 100)
                {
                    break;
                }
            }

            Console.WriteLine("Please enter the series type: Even or Odd ");

            while (!done)
            {                                   
                string series = Console.ReadLine();
                if (series == "Odd")
                {
                    Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                        done = true;
                    }
                }

                else if (series == "Even")
                {
                    Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                        done = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please only enter Odd or Even: ");
                }
            }
        }                   
    }  
}