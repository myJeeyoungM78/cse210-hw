Date: 1/20/2024
Class: CSE 210
Professor: Vaughn Poulson
Student: Jeeyoung Madsen

Articulate the principle of abstraction

Abstraction is simplifying complex systems.
The benefit of abstraction 1.Reduces complexity
                            2. Making it easier to design
This not oly simplifies the development process but also enhances code readability
and manitainability.

For example:

(public void SaveJournalToFile()
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
)
Abstraction is exemplified through the Journal class, which provids a clean interface 
for high-level operations like writing, displaying, and saving entries.



