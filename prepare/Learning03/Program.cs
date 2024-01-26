using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Fraction World!");

        Fraction f1 = new Fraction ();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction (5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction (3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction (1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }



public class Fraction
{
    private int _numerator;
    private int _denominator;


        // Fraction fraction = new fraction

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;

    }

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public float GetDecimalValue()
    {
        return (float) _numerator / (float) _denominator;
    }
    }

}