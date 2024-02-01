using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this._name = "Breathing";
        this._description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public override void Run()
    {
        base.Run();

        Random rand = new Random();
        int rtime = rand.Next(1,5);

        for (int i = 0; i < rtime; i++)
        {
            BreatheIn(5);
            BreatheOut(5);
        }

        Console.WriteLine("Done");
    }


    public void BreatheIn(int count)
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        for (int i = 0; i < count; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void BreatheOut(int count)
    {
        Console.WriteLine();
        Console.Write("Now breathe out...");
        for (int i = 0; i < count; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}