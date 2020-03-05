// This file is auto-generated! Edit DelegateFactoryServiceCollectionExtensions.tt instead
using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("GenericFactory.Tests")]
namespace GenericFactory
{
    public static class DelegateFactoryServiceCollectionExtensions
    {
        public static IServiceCollection AddFactory<TService>(this IServiceCollection services, Func<IServiceProvider, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService>
            >(provider => new DelegateFactory<TService>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1>(this IServiceCollection services, Func<IServiceProvider, TArg1, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1>
            >(provider => new DelegateFactory<TService, TArg1>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2>
            >(provider => new DelegateFactory<TService, TArg1, TArg2>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(provider, factoryFunction));
            return services;
        }

        public static IServiceCollection AddFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this IServiceCollection services, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TService> factoryFunction)
            where TService : class
        {
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
            >(provider => new DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(provider, factoryFunction));
            return services;
        }

    }
}
