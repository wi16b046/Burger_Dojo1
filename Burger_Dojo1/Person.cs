using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Dojo1
{
    //Testobject, Person with age firstname and lastname
    class Person
    {
        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("I am {0} {1} and I am {2} years old", FirstName, LastName, Age);
        }

    }
}
