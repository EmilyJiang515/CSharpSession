using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Class2: IRegistration
    {

        public void RegisterStudent(string student)
        {
            Console.WriteLine($@"The 2nd implementation for {student}");
        }
    }
}