using System;
using System.Collections.Generic;
using Interface.Activities;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IActivity> activityList = new List<IActivity>();

            string studentA = "Tom Barfoot";

            Register registerA = new Register();
            Exam examB = new Exam();

            activityList.Add(registerA);
            activityList.Add(examB);
            
            foreach (var registerItem in activityList)
            {
                registerItem.RegisterStudent(studentA);
            }

            Console.ReadKey();
        }
    }
}
