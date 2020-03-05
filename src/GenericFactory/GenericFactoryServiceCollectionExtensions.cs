// This file is auto-generated! Edit GenericFactoryServiceCollectionExtensions.tt instead
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("GenericFactory.Tests")]
namespace GenericFactory
{
    public static class GenericFactoryServiceCollectionExtensions
    {
        public static IServiceCollection AddFactory<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService>,
                GenericFactory<TService>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1>,
                GenericFactory<TService, TArg1>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2>,
                GenericFactory<TService, TArg1, TArg2>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3>,
                GenericFactory<TService, TArg1, TArg2, TArg3>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
            >();
            return services;
        }

        public static IServiceCollection AddFactory<TService, TImplementation, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddWeaklyTypedFactory<TService, TImplementation>();
            services.AddTransient
            <
                IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>,
                GenericFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
            >();
            return services;
        }

    }
}
