using System;
using GenericFactory.Tests.TestData;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace GenericFactory.Tests
{
    public class ProviderTests
    {
        [Fact]
        public void GetFactory_Unregistered_ReturnsNull()
        {
            var collection = new ServiceCollection();
            var provider = collection.BuildServiceProvider();

            var factory = provider.GetFactory<IFoo, UnregisteredDependency>();
            Assert.Null(factory);
        }

        [Fact]
        public void GetRequiredFactory_Unregistered_Throws()
        {
            var collection = new ServiceCollection();
            var provider = collection.BuildServiceProvider();

            Assert.Throws<InvalidOperationException>(() => provider.GetRequiredFactory<IFoo, UnregisteredDependency>());
        }
    }
}
