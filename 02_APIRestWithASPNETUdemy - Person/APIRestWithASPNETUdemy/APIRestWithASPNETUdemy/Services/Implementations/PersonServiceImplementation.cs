using APIRestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace APIRestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }


        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Rodolfo",
                LasttName = "Braga",
                Address = "Maria da Graça",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        #region  Metodos auxiliares-----------------------------------------------------------
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LasttName = "Person Last Name " + i,
                Address = "Address " + i,
                Gender = i % 2 == 0?"Male":"Female"
            };
        }

        private long IncrementAndGet()
        {
           
            return Interlocked.Increment(ref count);
        }
        #endregion
    }
}
