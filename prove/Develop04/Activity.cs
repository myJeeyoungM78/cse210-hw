using System;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    private List<string> spinner = new List<string>() {"|", "/", "-", "\\"};

    public Activity()
    {}

    public void DisplayStartingMessage()
    {
        System.Console.WriteLine($"Welcome to the {_name} Activty");
        System.Console.WriteLine(_description);
        // System.Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        System.Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activtiy.");
    }

    public void ShowSpinner(int seconds)
    {
        System.Console.Write("Get Ready...");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(spinner[i%4]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("\n\n");
    }

    public void ShowCountDown(int seconds)
    {
        System.Console.Write("Get Ready...");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("\n\n");
    }

    public virtual void Run()
    {
        //Start spinner
        // System.Console.WriteLine("Spinner ...");
    }

    public void SetDuration(int duration)
    {
        this._duration = duration;
    }
}