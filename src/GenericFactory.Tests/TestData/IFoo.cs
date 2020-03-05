namespace GenericFactory.Tests.TestData
{
    public interface IFoo
    {
        RegisteredDependency Registered { get; }
        UnregisteredDependency Unregistered { get; }
        void Print();
    }
}