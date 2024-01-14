using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        Random random = new Random();
        int MagicNum = random.Next(1, 100);
        
        int guess = 0;
        int guessTries = 0;

        while (guess != MagicNum)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            guessTries++;
            Console.WriteLine($"Magic number is {MagicNum}");

            if (guess < MagicNum)
            {
                Console.WriteLine("Higher");
            }

            if (guess > MagicNum)
            {
                Console.WriteLine("Lower");
            }

            if (guess == MagicNum)
            {
                Console.WriteLine("You guessed it!");
                System.Console.WriteLine($"It took {guessTries} tries to find the magic number");

                System.Console.WriteLine("Do you want to play again?");

                string input = Console.ReadLine();

                if (input.Equals("Yes"))
                {
                    //Playing again, change the magic number, guess and guess count

                    MagicNum = random.Next(1, 101);
                    guess = 0;
                    guessTries = 0;
                }
            }
        }

    }
}