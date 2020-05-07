using System;

namespace RepositoryPattern{

    public class Person{
        

        // we declare onle the place holder and 
        // maybe some decorrator
        // method override to make chage the appreance
        public int Id {get;set;}
        public string GivenName{get;set;}
        public string FamilyName{get;set;}

       
        public int Rating{get;set;}

        

        public override string ToString()
        {
           return $"Then name is {GivenName} and Family name {FamilyName}";
        }


        // we apply a default methodoverride


    }

}