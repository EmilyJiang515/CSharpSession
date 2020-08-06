using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace InterfaceExample
{
    public class Register: IRegistration
    {
        public bool IsRegistered { get; }
        public int TotalStudent { get; }

        public void RegisterStudent(string student)
        {
            Console.WriteLine($@"The {student} is registered");

        }
    }
}
