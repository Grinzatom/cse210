using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random Generator = new Random();
        int Number = Generator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here..
        while (guess != Number)
        {
            Console.Write("What is your number? ");
            guess = int.Parse(Console.ReadLine());

            if (Number > guess)
            {
                Console.WriteLine("High");
            }
            else if (Number < guess)
            {
                Console.WriteLine("Low");
            }
            else
            {
                Console.WriteLine("You win!");
            }

        }                    
    }
}