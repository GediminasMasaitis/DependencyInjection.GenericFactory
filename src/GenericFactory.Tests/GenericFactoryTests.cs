using GenericFactory.Tests.TestData;
using Moq;
using Xunit;

namespace GenericFactory.Tests
{
    public class GenericFactoryTests
    {
        [Fact]
        public void GenericFactory_Correct_CreatesInstances()
        {
            var registeredDependency = new RegisteredDependency { Value = "registered" };
            var unregisteredDependency = new UnregisteredDependency { Value = "unregistered" };
            var expectedInstance = new Foo(registeredDependency, unregisteredDependency);
            var weakFactoryMock = new Mock<IWeaklyTypedFactory<IFoo>>();
            weakFactoryMock.Setup(m => m.CreateService(unregisteredDependency)).Returns(expectedInstance);
            var factory = new GenericFactory<IFoo, UnregisteredDependency>(weakFactoryMock.Object);

            var instance = factory.CreateService(unregisteredDependency);

            weakFactoryMock.Verify(m => m.CreateService(unregisteredDependency), Times.Once());
            weakFactoryMock.VerifyNoOtherCalls();
            Assert.Same(expectedInstance, instance);
        }
    }
}
