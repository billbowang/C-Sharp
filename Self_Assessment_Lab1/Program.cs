using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentFirstName = "";
            string studentLastName = "";
            DateTime studentBirthDate;
            string studentAddr1 = "";
            string studentAddr2 = "";
            string studentCity = "";
            string studentState = "";
            string studentZIP = "";
            string studentCounty = "";

            Console.WriteLine("Please input your name:");
            studentFirstName = Console.ReadLine();
            Console.WriteLine("Your name is {0}", studentFirstName);
            Console.WriteLine($"Your name is {studentFirstName}");
            Console.Out.WriteLine("Test");
        }
    }
}
