// This file is auto-generated! Edit FactoryServiceProviderExtensions.tt instead
using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("GenericFactory.Tests")]
namespace GenericFactory
{
    public static class FactoryServiceProviderExtensions
    {
        public static IFactory<TService> GetFactory<TService>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService>>();
            return factory;
        }

        public static IFactory<TService> GetRequiredFactory<TService>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService>>();
            return factory;
        }

        public static IFactory<TService, TArg1> GetFactory<TService, TArg1>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1>>();
            return factory;
        }

        public static IFactory<TService, TArg1> GetRequiredFactory<TService, TArg1>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2> GetFactory<TService, TArg1, TArg2>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2> GetRequiredFactory<TService, TArg1, TArg2>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3> GetFactory<TService, TArg1, TArg2, TArg3>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3> GetRequiredFactory<TService, TArg1, TArg2, TArg3>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4> GetFactory<TService, TArg1, TArg2, TArg3, TArg4>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> GetFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>>();
            return factory;
        }

        public static IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> GetRequiredFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this IServiceProvider provider)
            where TService : class
        {
            var factory = provider.GetRequiredService<IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>>();
            return factory;
        }

    }
}
