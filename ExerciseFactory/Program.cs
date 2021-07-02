using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}{Environment.NewLine}{nameof(Name)}: {Name}"; 
        }   

        public class PersonFactory
        {
            public List<Person> people = new List<Person>();
            public Person CreatePerson(string name)
            {
                Person p = new Person
                {
                    Id = people.Count,
                    Name = name
                };
                people.Add(p);
                return p;
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var personFactory = new Person.PersonFactory();
            Person person1 = personFactory.CreatePerson("Ranieri");
            Person person2 = personFactory.CreatePerson("Antonia");
            Console.WriteLine(person1);
            Console.WriteLine(person2);

        }
    }
}
