using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();   
        job1. _jobTitle = "Software Engineer";
        job1. _company = "Microsoft";
        job1. _startYear = 2019;
        job1. _endYear = 2022;

        Job job2 = new Job();
        job2. _jobTitle = "Manager";
        job2. _company = "Apple";
        job2. _startYear = 2022;
        job2. _endYear = 2023;

        Resume myResume = new Resume();
        myResume. _name = "Allison Rose";

        myResume. _jobs.Add(job1);
        myResume. _jobs.Add(job2);

        myResume.DisplayResume();

        if (myResume._jobs.Count > 0)
        {
            string firstJobTitle = myResume._jobs[0]._jobTitle;
            Console.WriteLine($"First job title: {firstJobTitle}");
        }

        
 
    
    }

    public class Job
    {
        public string _jobTitle = "";
        public string _company = "";
        public int _startYear;
        public int _endYear;

        public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    }
    
    public class Resume

    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        // public Resume()
        // {
        //     _name = name;
            
        // }

        // public Resume();
        public void DisplayResume()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs: ");

            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }

        // public override bool Equals(object obj)
        // {
        //     return obj is Resume resume &&
        //            _name == resume._name;
        // }
    }
}