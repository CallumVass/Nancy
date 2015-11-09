using System;

namespace Nancy.Host
{
    using global::Nancy.Hosting.Self;

    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new NancyBootstrapper(), new Uri(@"http://localhost:1234")))
            {
                host.Start();
                Console.ReadLine();
            }
        }
    }
}
