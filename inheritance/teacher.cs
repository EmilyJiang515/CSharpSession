using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    public class teacher:Person
    {
        public void LessonsToTeach()
        {
            Console.WriteLine($@"this is the lesson teach");
        }
    }
}
