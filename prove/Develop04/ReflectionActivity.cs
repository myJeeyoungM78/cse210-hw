public class ReflectionActivity : Activity
{

    public ReflectionActivity()
    {
        this._name = "Reflection";
        this._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    }

    string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    private List<string> spinner = new List<string>() {"|", "/", "-", "\\"};
    public override void Run()
    {
        // base.Run();

        Random rand = new Random();
        string prompt = prompts[rand.Next(0, prompts.Length)];
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine(DisplayPrompt());
        ShowCountDown(5);

        while (DateTime.Now < endTime)
        {
            System.Console.WriteLine(DisplayQuestions());
            ShowSpinner(7);
        }
    }

    public string DisplayPrompt() 
    {
        Random rand = new Random();
        string question = prompts[rand.Next(0, prompts.Length)];
        return question;
    }

    public string DisplayQuestions()
    {
        Random rand = new Random();
        string question = questions[rand.Next(0, questions.Length)];
        return question;
    }


}