using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Welcome to the program!");
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!"); 
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        
        return square;
    }
    
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }



}

