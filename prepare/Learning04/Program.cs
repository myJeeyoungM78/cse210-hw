using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Roberto Rodrigiuez ", "Fractions", "7.3", "3-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World WarII");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingAssignment());
    }
}