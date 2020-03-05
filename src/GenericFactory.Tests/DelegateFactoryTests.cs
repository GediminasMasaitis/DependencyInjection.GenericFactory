using System;
using GenericFactory.Tests.TestData;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace GenericFactory.Tests
{
    public class DelegateFactoryTests
    {
        [Fact]
        public void DelegateFactory_CreatesInstances()
        {
            var registeredDependency = new RegisteredDependency { Value = "registered" };
            var unregisteredDependency = new UnregisteredDependency { Value = "unregistered" };
            var expectedInstance = new Foo(registeredDependency, unregisteredDependency);
            var providerMock = new Mock<IServiceProvider>();
            var provider = providerMock.Object;
            
            var timesCalled = 0;
            IFoo FactoryFunc(IServiceProvider prov, UnregisteredDependency dep)
            {
                timesCalled++;
                Assert.Same(provider, prov);
                Assert.Same(unregisteredDependency, dep);
                return expectedInstance;
            }

            var factory = new DelegateFactory<IFoo, UnregisteredDependency>(provider, FactoryFunc);
            var instance = factory.CreateService(unregisteredDependency);
            Assert.Same(expectedInstance, instance);
            Assert.Equal(1, timesCalled);
            providerMock.VerifyNoOtherCalls();
        }
    }
}
