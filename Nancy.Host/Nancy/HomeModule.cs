namespace Nancy.Host.Nancy
{
    using System.Collections.Generic;

    using global::Nancy.Data;
    using global::Nancy.Data.Models;

    public class PeopleModule : NancyModule
    {
        private readonly IPersonRepository personRepository;

        public PeopleModule(IPersonRepository personRepository)
            : base("/people")
        {
            this.personRepository = personRepository;

            Get["/"] = _ => AllPeople();
        }

        public IEnumerable<Person> AllPeople()
        {
            return this.personRepository.GetPeople();
        }
    }
}
