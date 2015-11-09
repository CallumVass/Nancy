namespace Nancy.Host
{
    using global::Nancy.Data;
    using global::Nancy.TinyIoc;

    public class NancyBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            container.Register<IPersonRepository>(new PersonRepository());
        }
    }
}