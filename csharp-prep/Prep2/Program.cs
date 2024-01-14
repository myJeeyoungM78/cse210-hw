using System;
using System.Runtime.Serialization;

class Program
{
    private static int A = 90;
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string percent = Console.ReadLine();

        int grade = int.Parse(percent);
        int lastDigit = grade;

        int onesDigit = int.Parse(percent.Substring(percent.Length - 1, 1));

        string letter = "";

        if (grade >= A)
        {
            letter = ("A");
        }
        else if ( grade >= 80)
        {
            letter = ("B");
        }
        else if (grade >= 70)
        {
            letter = ("C");
        }
        else if (grade >= 60)
        {
            letter = ("D");
        }
        else if (grade < 60)
        {
            letter = ("F");
        }

        if (onesDigit >= 7)
        {
            if (grade < A && grade > 60)
            {
                letter += "+";
            }
        }
        
        if (onesDigit <= 3)
        {
            if (grade > 60)
            {
                letter += "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation you passed");
        }

        else 
        {
            Console.WriteLine("I am sorry better luck next time");
        }

    }
}
