using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RepositoryPattern{

    public class AppliedRepository : iPersonRepository
    {


        List <Person> people  =new List<Person>();
         // ceate the object here
         Person p1 = new Person{
             Id = 1,
             GivenName = "Tanvir rahman",
             FamilyName = "Rahman",
             Rating = 3
         };
         Person p2 = new Person{
             Id = 1,
             GivenName = "Tanvir Ahmed ornob",
             FamilyName = "ahmed",
             Rating = 4
         };
         Person p3 = new Person{
             Id = 1,
             GivenName = "Zakariabijoy",
             FamilyName = "mirja ",
             Rating = 3
         };
         Person p4 = new Person{
             Id = 1,
             GivenName = "Ornob rahman",
             FamilyName = "Ornob Rahman",
             Rating = 3
         };

       
        public void AddPerson(Person newPerson)
        {
            
            people.Add(newPerson);
            
        }

        public void DeletePerson(int id)
        {
            // find the person
            // implement
            // implement it
            // get a prson and then remove it
            var pr =  people.Find(x=>x.Id ==id);
            people.Remove(pr);
        }

        public IEnumerable<Person> GetPeople()
        {
            // first we need a list to store all the
            // person obejct 
            
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);

            return people;

        }

        public Person GetPerson(int id)
        {
           return people.Find(x=>x.Id ==id);

        }

        public Person UpdatePerson(int id, Person updatedPerson)
        {
            // get the person the update the parameter
            // then retun the person1
            Person person =  people.Find(x=>x.Id ==id);

            Console.WriteLine("before update");
            Console.WriteLine(person);
            // now change the person attribute
            person.Id  = updatedPerson.Id;
            person.GivenName = updatedPerson.GivenName;
            person.FamilyName = updatedPerson.FamilyName;
            person.Rating = updatedPerson.Rating;
            //Console.WriteLine(person);
           // Console.WriteLine(updatedPerson);
            return person;


        }
    }

}