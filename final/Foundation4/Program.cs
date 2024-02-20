using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime now = new DateTime(2024, 01, 01);

        Running r1 = new Running(2, now, 30);
        
        Cycling c1 = new Cycling(now.AddDays(1), 10, 6.0);
        Swimming s1 = new Swimming(now.AddDays(2), 10, 60);

        System.Console.WriteLine(r1.GetSummary());
        System.Console.WriteLine(c1.GetSummary());

        System.Console.WriteLine(s1.GetSummary());


    }
}