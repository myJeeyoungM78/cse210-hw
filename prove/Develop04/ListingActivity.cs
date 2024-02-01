using System;

public class ListingActivity : Activity
{
    // List<string> promts;
    // Random rand;
    public int _count;

    public ListingActivity()
    {
        this._name = "Listing";
        this._description = "Consider the following prompt: ";
    }

    string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public override void Run()
    {

        Random rand = new Random();
        string prompt = prompts[rand.Next(1, prompts.Length)];
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> userResponses = new List<string>();
        string userInput = "";
        Console.WriteLine($"---{prompt}---");
        ShowCountDown(5);
        Console.Write("Type item and press enter: (type 'done' to exit)");

        while(!userInput.Equals("done") && DateTime.Now < endTime)
        {
            userInput = Console.ReadLine();

            if (userInput.ToLower().Equals("done"))
            {
                break;
            }

            userResponses.Add(userInput);
        }

        System.Console.WriteLine($"You entered {userResponses.Count()}");
        // foreach (string r1 in userResponses)
        // {
        //     Console.WriteLine(r1);
        // }
    }

}