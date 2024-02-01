using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App");
        Console.WriteLine("Please choose the activity you would like to use.");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        string input = Console.ReadLine();

        Activity act;
        switch (input)
        {
            case "1":
                act = new BreathingActivity();
                break;
            case "2":
                act = new ReflectionActivity();
                break;
            case "3":
                act = new ListingActivity();
                break;
            case "4":
            default:
            return;
        }

        act.DisplayStartingMessage();
        // Get the activity time from the user
        // Console.Clear();
        System.Console.WriteLine("How long, in seconds, would you like for your session?");
        string actvityTime = Console.ReadLine();
        act.SetDuration(int.Parse(actvityTime));
        Console.Clear();
        act.ShowSpinner(12);
        act.Run();

        act.ShowSpinner(4);

        act.DisplayEndingMessage();







        System.Console.WriteLine();
    }
}