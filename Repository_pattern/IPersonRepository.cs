using System.Collections;
using System.Collections.Generic;

namespace RepositoryPattern{

    // we define a interfce here
    public interface iPersonRepository{

        // one method that return a list of person
        // one method that return a person by id
        // a void method that Add a person
        // and a Delete method

        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
        void AddPerson(Person newPerson);
        Person UpdatePerson(int id,Person updatedPerson);
        void DeletePerson(int id);

    }

}