using System;
using Microsoft.Extensions.DependencyInjection;

namespace GenericFactory.TestCli
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddTransient<RegisteredDependency>(_ => new RegisteredDependency { Value = "registered" });
            //collection.AddFactory<IFoo, Foo, UnregisteredDependency>();
            collection.AddFactory<IFoo, UnregisteredDependency>((prov, dep) => new Foo(prov.GetService<RegisteredDependency>(), dep));
            //collection.AddTransient<IFactory<IFoo, UnregisteredDependency>, ManualFactory>();
            var provider = collection.BuildServiceProvider();


            var factory = provider.GetRequiredFactory<IFoo, UnregisteredDependency>();
            var unregistered = new UnregisteredDependency();
            unregistered.Value = "unregistered";
            var foo = factory.CreateService(unregistered);
            foo.Print();

            Console.ReadLine();
        }
    }

    class ManualFactory : IFactory<IFoo, UnregisteredDependency>
    {
        private readonly IServiceProvider _provider;

        public ManualFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IFoo CreateService(UnregisteredDependency arg1)
        {
            var registered = _provider.GetService<RegisteredDependency>();
            return new Foo(registered, arg1);
        }
    }

    class RegisteredDependency
    {
        public string Value { get; set; }
    }

    class UnregisteredDependency
    {
        public string Value { get; set; }
    }

    internal interface IFoo
    {
        void Print();
    }

    class Foo : IFoo
    {
        private readonly RegisteredDependency _registered;
        private readonly UnregisteredDependency _unregistered;

        public Foo(RegisteredDependency registered, UnregisteredDependency unregistered)
        {
            _registered = registered;
            _unregistered = unregistered;
        }

        public void Print()
        {
            Console.WriteLine($"{_registered.Value}; {_unregistered.Value}");
        }
    }
}
