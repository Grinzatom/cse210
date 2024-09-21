using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //list integer number only
        List<int> numbers = new List<int>();
        
        //inittial value of the enter user variable
        int NumberEntry = -1;
        while (NumberEntry != 0)
        {
            Console.Write("Enter a number (0 to quit, only integer numbers.): ");
            // convert string to integer only
            string userResponse = Console.ReadLine();
            NumberEntry = int.Parse(userResponse);
            
            //if the user number its diferent of 0 add the usaer number to the list
            if (NumberEntry != 0)
            {
                numbers.Add(NumberEntry);
            }
        }

        //sum variable initial value. next sum each value added by the user
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        //print the total value of the sum
        Console.WriteLine($"Total sum: {sum}");

        //divide the total for the numbers of elements in the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"average: {average} ");

       // find the  a biguest value wrote by the user
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        // print the final value in mx variable when the contdition is solved
        Console.WriteLine($"The biguer: {max}");
    }
}