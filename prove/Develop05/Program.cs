using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
       GoalManager gm = new GoalManager();

       gm.Start();
    }
}

    // List<string> _name;
    // List<string> _description;
    // List<string> _points;

    //         _name = new List<string>();
    //     _description = new List<string>();
    //     _points = new List<string>();
