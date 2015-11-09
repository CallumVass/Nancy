using System.Collections.Generic;
using System.Linq;

namespace Nancy.Data
{
    using Nancy.Data.Models;

    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            return Enumerable.Range(1, 1000).Select(x => new Person { Id = x, Name = string.Format("Person {0}", x) });
        } 
    }
}
