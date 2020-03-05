using System;

namespace GenericFactory.Tests.TestData
{
    public class Foo : IFoo
    {
        public RegisteredDependency Registered { get; }
        public UnregisteredDependency Unregistered { get; }

        public Foo(RegisteredDependency registered, UnregisteredDependency unregistered)
        {
            Registered = registered;
            Unregistered = unregistered;
        }

        public void Print()
        {
            Console.WriteLine($"{Registered.Value}; {Unregistered.Value}");
        }
    }
}