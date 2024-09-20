using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("whats your percentage grade?: ");
       string percent = Console.ReadLine();
       int percentval = int.Parse(percent);

       string calification = "";

       if(percentval >= 90)
       {
         calification = "A";
       }
       else if(percentval >= 80)
       {
          calification = "B";  
       }
       else if(percentval >= 70)
       {
          calification = "C";  
       }
       else if(percentval >= 60)
       {
          calification = "D";  
       }
       else 
       {
          calification = "F";  
       }

       Console.WriteLine($"Yuor grade is: {calification}");

       if (percentval >= 70)
       {
         Console.WriteLine("you passed!!");
       }

       else
       {
         Console.WriteLine("not passed!");
       }
    }
}