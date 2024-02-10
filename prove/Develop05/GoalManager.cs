

public class GoalManager
{
    /// <summary>
    /// List of all of the goals being tracked
    /// </summary>
    private List<Goal> _goals;

    /// <summary>
    /// Total points for all goals accomplished
    /// </summary>
    private int _score = 0;

    public GoalManager()
    {
        this._goals = new List<Goal>();
    }

    /// <summary>
    /// This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    /// </summary>
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Eternal Quest Program specification\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Display Score");

            Console.WriteLine("\t2. Create New Goal");
            Console.WriteLine("\t3. Record Event");
            Console.WriteLine("\t4. List Goals");
            Console.WriteLine("\t5. Save Goals");
            Console.WriteLine("\t6. Load Goals");
            Console.WriteLine("\t7. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    ListGoalDetails();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                default:
                    return;
            }
        }
    }

    /// <summary>
    /// Displays the players current score.
    /// </summary>
    public void DisplayPlayerInfo()
    {
        Console.Clear();
        System.Console.Write($"Your score is: {_score}\n\n");
    }

    /// <summary>
    /// Lists the names of each of the goals.
    /// </summary>
    public void ListGoalNames()
    { 
        foreach (Goal g in _goals)
        {
            System.Console.WriteLine(g.Name);
        }
    } 

    /// <summary>
    /// Lists the details of each goal (including the checkbox of whether it is complete).
    /// </summary>
    public void ListGoalDetails()
    {
        Console.Clear();
        System.Console.WriteLine("List of Goals:");
        if (_goals.Count == 0)
        {
            System.Console.WriteLine("\t <EMPTY>\n\n");
            return;
        }

        foreach (Goal g in this._goals)
        {
           System.Console.WriteLine(g.GetDetailsString());
        }

        System.Console.WriteLine("\n\n");
    }

    /// <summary>
    ///  Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    /// </summary>
    public void CreateGoal()
    {
        Console.Clear();
        System.Console.WriteLine("What kind of goal would you like to create:");
        System.Console.WriteLine("\t1: Simple Goal");
        System.Console.WriteLine("\t2: Eternal Goal");
        System.Console.WriteLine("\t3: Check List Goal");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateCheckListGoal();
                break;
            default:
                break;
        }

    }

    private void CreateCheckListGoal()
    {
        Console.Clear();

        System.Console.WriteLine("What would you like to name your simple goal");
    }

    private void CreateEternalGoal()
    {
        throw new NotImplementedException();
    }

    private Goal CreateSimpleGoal()
    {
        //Gather info from user to generate a simple goal

        Goal goal = new SimpleGoal();
        goal.Type = "Simple";
        GatherGoalInfo(ref goal);
  

        _goals.Add(goal);
        System.Console.WriteLine($"\nAdding new goal {goal}");
        System.Console.WriteLine($"Total goals {_goals.Count}\n");
        return goal;
    }

    
    public void GatherGoalInfo(ref Goal goal)
    {
        // Console.Clear();

        System.Console.WriteLine($"What would you like to name your {goal.Type} goal?");
        string name = Console.ReadLine();
        goal.Name = name;
        System.Console.WriteLine($"Name set for goal {goal.Name}");

        System.Console.WriteLine($"\nDescribe your {goal.Name} goal.");
        string description = Console.ReadLine();
        goal.Description = description;
        System.Console.WriteLine($"Description set for {goal.Name}");

        System.Console.WriteLine($"\nHow many points is {goal.Name} worth?");
        int points = int.Parse(Console.ReadLine());
        goal.Points = points;
        System.Console.WriteLine($"Point set for {goal.Name}");
    }

    /// <summary>
    ///  Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    /// </summary>
    public void RecordEvent()
    {

        for (int i = 0; i < _goals.Count; i++)
        {
            System.Console.WriteLine($"{i} - {_goals[i]}");
        }

        System.Console.WriteLine("Select the number for the goal you want to record.");

        string input = Console.ReadLine();

        Goal goal = _goals[int.Parse(input)];

        goal.RecordEvent();

        _score += goal.GetPointsForScore();

    }

    /// <summary>
    ///  Saves the list of goals to a file.
    /// </summary>
    public void SaveGoals()
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Goal g in _goals)
            {
                System.Console.WriteLine($"Adding goal to file: {g.GetDetailsString()}");
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    /// <summary>
    ///  Loads the list of goals from a file.
    /// </summary>
    public void LoadGoals()
    {

    }
}