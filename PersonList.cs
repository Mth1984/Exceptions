using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class PersonList
    {
        List<Person> MyPersonList { get; set; } = new List<Person>();

        public void AddPerson(Person person)
        {
            // Throw Exeption when Person already exists in the list
            if (person == MyPersonList.Find(i => i == person))
            {
                int personID = MyPersonList.FindIndex(i => i == person);
                throw new PersonExeption($"Person allready exist!!", person.Name, personID);
            }

            this.MyPersonList.Add(person);
        }


    }
}
