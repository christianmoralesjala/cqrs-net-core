using MainLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace MainLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 2, FirstName = "Elton", LastName = "Cassas" });
            people.Add(new PersonModel { Id = 2, FirstName = "Andy", LastName = "Camacho" });
            people.Add(new PersonModel { Id = 1, FirstName = "Christian", LastName = "Morales" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}
