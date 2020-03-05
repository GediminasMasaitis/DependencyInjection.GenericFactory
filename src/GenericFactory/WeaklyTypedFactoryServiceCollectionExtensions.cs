using Microsoft.Extensions.DependencyInjection;

namespace GenericFactory
{
    public static class WeaklyTypedFactoryServiceCollectionExtensions
    {
        public static IServiceCollection AddWeaklyTypedFactory<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddSingleton<IWeaklyTypedFactory<TService>, WeaklyTypedFactory<TService, TImplementation>>();
            return services;
        }
    }
}