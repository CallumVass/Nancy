namespace Nancy.Data
{
    using System.Collections.Generic;

    using Nancy.Data.Models;

    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
    }
}