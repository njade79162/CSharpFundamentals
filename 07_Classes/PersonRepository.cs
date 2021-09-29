using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    class PersonRepository
    {
        List<Person> personList = new List<Person>();

        public void AddPerson(Person person)
        {
            personList.Add(person);
        }

        public List<Person> ReturnList()
        {
            return personList;
        }

        public void RemovePerson(Person person)
        {
            personList.Remove(person);
        }
    }
}
