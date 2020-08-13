using System;

namespace Interface.Activities
{
    class Exam: IActivity
    {

        public void RegisterStudent(string student)
        {
            Console.WriteLine($@"The 2nd implementation for {student}");
        }
    }
}