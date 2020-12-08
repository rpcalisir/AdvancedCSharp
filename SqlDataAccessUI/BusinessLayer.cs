using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessUI
{
    public class BusinessLayer
    {
        public List<Person> GetPeopleByLastName(string LastName)
        {
            var people = new List<Person>()
            {
                new Person{FirstName = "a first", LastName = "a last", EmailAddress = " a email", PhoneNumber = "a phone"},
                new Person{FirstName = "b first", LastName = "b last", EmailAddress = " b email", PhoneNumber = "b phone"},
                new Person{FirstName = "c first", LastName = "c last", EmailAddress = " c email", PhoneNumber = "c phone"}
            };
            return people.Where(f => f.LastName.Equals(LastName)).ToList();
        }
    }
}