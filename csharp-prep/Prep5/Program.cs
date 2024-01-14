using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int userNum = PromptUserNumber();
        int squared = SquareNumber(userNum);

        DisplayResult(username, squared);
    }

    private static void DisplayResult(string username, int squared)
    {
       System.Console.WriteLine($"{username}, the square of your number is {squared}");
    }

    static int SquareNumber(int userNum)
    {
        return userNum * userNum;
    }

    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        System.Console.Write("Please enter your name: ");
        string input = Console.ReadLine();
        return input;
    }

    static int PromptUserNumber()
    {
        System.Console.Write("Please enter your favorite number: ");
        int input = int.Parse(Console.ReadLine());
        return input;
    }

}