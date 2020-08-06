using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<IRegistration> registersList = new List<IRegistration>();

            string studentA = "Tom Barfoot";

            Register registerA=new Register();
            Class2 registerB=new Class2();

            registersList.Add(registerA);
            registersList.Add(registerB);
            
            foreach (var registerItem in registersList)
            {
                registerItem.RegisterStudent(studentA);
            }

            Console.ReadKey();
        }
    }
}
