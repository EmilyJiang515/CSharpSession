using System;

namespace inheritance
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int age { get; set; }
        public bool gender;

        public virtual void Hobbies()
        {
            Console.WriteLine("A person like food");
        }

        public static string GetName(string argFirstName, string argLastName)
        {
            var name = argFirstName + " - " + argLastName;
            return name;
        }

        public static string GetGenderValue(bool argGender)
        {
            var genderValue=argGender ? "he" : "she";
            return genderValue;
        }

        private void GetSkill()
        {
            Teach();
            Cook();
        }

        private void Cook()
        {
            Console.WriteLine("a person can cook");
        }

        private void Teach()
        {
            Console.WriteLine("A person can teach");
        }
    }
}
