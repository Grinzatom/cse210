using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
       
        int NumberEntry = -1;
        while (NumberEntry != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            NumberEntry = int.Parse(userResponse);
            
           
            if (NumberEntry != 0)
            {
                numbers.Add(NumberEntry);
            }
        }

        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Total sum: {sum}");

        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"average: {average}");

       
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The biguer: {max}");
    }
}