

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to my Journal!");
        // a code template for the category, public class Journal
        Journal journal = new Journal();
        string choice = "";

        while (!choice.Equals("5"))
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WrtiteJournalEntry();
                    break;
                case "2":
                    journal.DisplayJournalEntry();
                    break;
                case "3":
                    journal.SaveJournalToFile();
                    break;
                case "4":
                    journal.LoadJournalFromFile();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }   
    }
}


public class Journal
{
    List<JournalEntry> journalEntries;
    List<string> prompts;
    Random rand;
    string filename = "C:\\Users\\jeeyo\\Documents\\myFile.txt";

    public Journal()
    {
        // require the "new" keyword when calling a constructor
        journalEntries = new List<JournalEntry>();
        rand = new Random();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you eat for today?"

        };

    }

    public string getRandomPrompt()
    {
        int randomNum = rand.Next(0, prompts.Count);
        return prompts[randomNum];
    }

    // read all journal entries from a file into the journal list
    public void LoadJournalFromFile()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // string[] parts = line.Split(",");

            // string date = parts[0];
            // string prompt = parts[1];
            // string reponse = parts[2];

            JournalEntry entry = new JournalEntry(line);
            addEntry(entry);
        }
    }

    // Print all journal entries to the console
    public void DisplayJournalEntry()
    {
        foreach (JournalEntry j in journalEntries)
        {
            System.Console.WriteLine(j.ToString());
        }
    }

    // Write all journal entires from list to file and close file
    public void SaveJournalToFile()
    {
        if (journalEntries.Count == 0)
        {
            // don't overwirte the file the list is empty
            return;
        }

       
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            foreach (JournalEntry j in journalEntries)
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(j.printToFIle());
            }
        }
    }

    // Allow user to create a new jouirnal entry from inputs from the console
    public void WrtiteJournalEntry()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();
        string prompt = getRandomPrompt();
        System.Console.WriteLine(prompt);
        string response = Console.ReadLine();

        JournalEntry entry = CreateJournalEntry(dateText, prompt, response);

        // Add entry to the journal list
        addEntry(entry);
    }

    public JournalEntry CreateJournalEntry(string date, string prompt, string response)
    {
        JournalEntry entry = new JournalEntry(date, prompt, response);

        return entry;
    }

    public void addEntry(JournalEntry entry)
    {
        journalEntries.Add(entry);
    }
}

public class JournalEntry
{
    private string _date;
    private string _prompt;
    private string _response;

    //Constructor for reading from a file
    public JournalEntry(string entry)
    {
        string[] items = entry.Split(",");

        _date = items[0];
        _prompt = items[1];
        _response = items[2];

    }

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public override string ToString()
    {
        return _date + " " + _prompt + "\n" + _response + "\n\n";
    }

    public string printToFIle()
    {
        return $"{_date},{_prompt},{_response}";
    }

    public string getDate()
    {
        return _date;
    }
}
