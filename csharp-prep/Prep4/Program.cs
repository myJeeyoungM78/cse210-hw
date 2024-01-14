using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        string SeriesNum = "1";

        List<int> listNum = new List<int>();

        while (!SeriesNum.Equals("0"))
        {
            Console.Write("Enter number: ");
            SeriesNum = Console.ReadLine();

            if (!SeriesNum.Equals("0"))
            {
                listNum.Add(int.Parse(SeriesNum));
            }
        }

        int sum = listNum.Sum();
        double avg = listNum.Average();
        int max = listNum.Max();
        int min = listNum.Where(number => number > 0).DefaultIfEmpty(0).Min();
        listNum.Sort();


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number is: {min}");
        Console.WriteLine("The sorted list is:");
        foreach (int i in listNum)
        {
            System.Console.WriteLine(i);
        }


    


        // if (int SeriesNum = 0; number.Count; SeriesNum++)
        //     {
        //         numbers.Add(Seriesnum);
        //     }

        //     int sum = 0;
        //     {
        //         sum += SeriesNum;
        //     }
        //     {
        //         Console.WriteLine($"The sum is: {sum}")
        //     }
    }

}