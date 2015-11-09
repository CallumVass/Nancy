using System;

namespace SomeOtherClient
{
    using Nancy.Data;
    using Nancy.Host.Nancy;

    class Program
    {
        static void Main(string[] args)
        {
            var personRepository = new PersonRepository();
            var peopleModule = new PeopleModule(personRepository);

            var people = peopleModule.AllPeople();

            Console.ReadLine();
        }
    }
}
