using System;

class Program
{
    static void Main(string[] args)
    {
        message();
        string userName = name();
        int userNumber = number();
        int squaredNumber = SquareNumber(userNumber);
        result(userName, squaredNumber);
    }

    static void message()
    {
        Console.WriteLine("Welcome !");
    }

    static string name()
    {
        Console.Write("what is your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int number()
    {
        Console.Write("what is your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number: {square}");
    }
}