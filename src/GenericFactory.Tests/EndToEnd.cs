using GenericFactory.Tests.TestData;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace GenericFactory.Tests
{
    public class EndToEnd
    {
        [Fact]
        public void GenericFactory_CreatesInstances()
        {
            var collection = new ServiceCollection();
            var registeredDependency = new RegisteredDependency { Value = "registered" };
            var unregisteredDependency = new UnregisteredDependency { Value = "unregistered" };
            collection.AddTransient<RegisteredDependency>(_ => registeredDependency);
            collection.AddFactory<IFoo, Foo, UnregisteredDependency>();
            var provider = collection.BuildServiceProvider();

            var factory = provider.GetRequiredFactory<IFoo, UnregisteredDependency>();
            Assert.NotNull(factory);

            var instance = factory.CreateService(unregisteredDependency);
            Assert.NotNull(instance);
            Assert.IsType<Foo>(instance);
            Assert.Same(instance.Registered, registeredDependency);
            Assert.Same(instance.Unregistered, unregisteredDependency);
        }

        [Fact]
        public void DelegateFactory_CreatesInstances()
        {
            var collection = new ServiceCollection();
            var registeredDependency = new RegisteredDependency { Value = "registered" };
            var unregisteredDependency = new UnregisteredDependency { Value = "unregistered" };
            collection.AddTransient<RegisteredDependency>(_ => registeredDependency);
            collection.AddFactory<IFoo, UnregisteredDependency>((prov, dep) => new Foo(prov.GetService<RegisteredDependency>(), dep));
            var provider = collection.BuildServiceProvider();

            var factory = provider.GetRequiredFactory<IFoo, UnregisteredDependency>();
            Assert.NotNull(factory);

            var instance = factory.CreateService(unregisteredDependency);
            Assert.NotNull(instance);
            Assert.IsType<Foo>(instance);
            Assert.Same(instance.Registered, registeredDependency);
            Assert.Same(instance.Unregistered, unregisteredDependency);
        }
    }
}
