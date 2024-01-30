Date: 1/29/2024
Class: CSE 210 
Professor : Vaughn Poulson
Student: Jeeyoung Madsen

Articulate the principle of inheritance.

1. Inheritance is
    * the ability for one class to obtain the attributes and methods of another class
    * a new class inherits attributes and methods from an existing class
    * forming an "is-a"(parent class from a child class)

2. Benefit:
    * one key benefit of inheritance is code reuse
    * By inheriting from a base class a child class can leverage the existing class without duplicating code.

3. * you have a base class (ex. sports or player)
    * you can create child class (ex. soccer. baseball....)
    * parent class could contain common properties and methods
    *child class could inherit from parent class and properites and methods
    
* Parent Class

public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic; 
    }
}

* Child Class

using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";


    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}

