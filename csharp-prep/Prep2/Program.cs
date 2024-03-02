using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("whats your percentage grade?: ");
       string percent = Console.ReadLine();
       int perval = int.Parse(percent);

       string calification = "";

       if(perval >= 90)
       {
         calification = "A";
       }
       else if(perval >= 80)
       {
          calification = "B";  
       }
       else if(perval >= 70)
       {
          calification = "C";  
       }
       else if(perval >= 60)
       {
          calification = "D";  
       }
       else 
       {
          calification = "F";  
       }

       Console.WriteLine($"Yuor grade is: {calification}");

       if (perval >= 70)
       {
         Console.WriteLine("you passed!!");
       }

       else
       {
         Console.WriteLine("not passed!");
       }
    }
}