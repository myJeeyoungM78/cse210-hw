using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video v1 = new Video("Making Pizza", "John Made it", 100);
        Video v2 = new Video("C# programing", "Jeeyoung", 5);
        Video v3 = new Video("Angry Boy", "Liam", 360);
        Video v4 = new Video("Earthquake in Hungry", "Isabella", 5000);

        
        Comment c1 = new Comment("Joey", "This was a great video!!");
        Comment c2 = new Comment("Happy", "Thank you for helping");
        Comment c3 = new Comment("Merry", "He is so fun");
        Comment c4 = new Comment("April", "It is amazing");
        


        v1.AddComment(c1);
        v2.AddComment(c2);
        v3.AddComment(c3);
        v4.AddComment(c4);


        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);





        //Display all video information

        foreach(Video v in videos)
        {
            v.GetDisplayInfo();
            System.Console.WriteLine("\n");
        }

    }
}