using System;
using System.Globalization;

public class WritingAssignment : Assignment
{
    // private String _topic;
    private string _title = "";


    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
        // _topic = topic;
    }

    public string GetWritingAssignment()
    {
        string studentName = GetStudentName();

        return $"Title: {_title} by {_studentName}";
    }

}