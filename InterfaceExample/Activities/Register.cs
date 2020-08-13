using System;

namespace Interface.Activities
{
    public class Register: IActivity
    {
        public bool IsRegistered { get; }
        public int TotalStudent { get; }

        public void RegisterStudent(string student)
        {
            Console.WriteLine($@"The {student} is registered");

        }
    }
}
