using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
