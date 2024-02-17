using System;

class Program
{
    static void Main(string[] args)
    {
        List<Events> events = new List<Events>();

        Address a1 = new Address("500 N Courtview", "Provo","Utah", "USA" );

        Lectures lecture = new Lectures("How to grow children", "Raising children like growing corn", "January 1, 2024", "8 A.M.", a1, "Joe Cally", 25);

        events.Add(lecture);

        Receptions reception1 = new Receptions("Anderson Wedding", "Joe and Wendy getting married", "October 13, 2024", "6 P.M.", a1, "jw@gmail.com");

        events.Add(reception1);

        Outdoorgatherings od1 = new Outdoorgatherings("Picknick", "Thompson Family Picknik", "June 14, 2024", "1 P.M.", a1, "Clear skies, 100 F");

        events.Add(od1);


        foreach(Events e in events)
        {
            System.Console.WriteLine(e.GetStandardDetails());
            System.Console.WriteLine("\n");
            System.Console.WriteLine(e.GetFullDetails());
            System.Console.WriteLine("\n");
            System.Console.WriteLine(e.GetShortDescription());

        }
    }
}