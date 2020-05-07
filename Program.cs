using System;
using System.Collections.Generic;
namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable <Person> ls = new List<Person>();
            AppliedRepository ap = new AppliedRepository();
            var ls = ap.GetPeople();
            
            foreach(var item in ls){
                Console.WriteLine(item);
            }

            var p = new Person{
                Id = 100,
                GivenName = "tanvir Rahman the csharp GOD",
                FamilyName = "Worrior GOD",
                Rating = 0
            };
            ap.AddPerson(p);
            
            foreach(var item in ls){
                Console.WriteLine(item);
            }


            // code for geting  aperson
            var person = ap.GetPerson(100);

            Console.WriteLine(person);
            Console.WriteLine("---------------------");
            //ap.DeletePerson(100);
            foreach(var item in ls){
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------");

            Person updated_person = new Person{
                Id = 123,
                GivenName = "tanvir 123",
                FamilyName = "Worrior123",
                Rating = 0
            };

            var person2 = ap.UpdatePerson(1,updated_person);
            Console.WriteLine("After Update");
            Console.WriteLine(person2);

            
        }
    }
}
