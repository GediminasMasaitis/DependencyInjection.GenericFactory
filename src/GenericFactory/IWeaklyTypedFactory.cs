namespace GenericFactory
{
    public interface IWeaklyTypedFactory
    {
        object CreateService(params object[] arguments);
    }

    public interface IWeaklyTypedFactory<out TService> : IWeaklyTypedFactory
        where TService : class
    {
        new TService CreateService(params object[] arguments);
    }
}