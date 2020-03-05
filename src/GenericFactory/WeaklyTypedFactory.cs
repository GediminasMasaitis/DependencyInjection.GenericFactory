using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("GenericFactory.Tests")]
namespace GenericFactory
{
    internal class WeaklyTypedFactory : IWeaklyTypedFactory
    {
        private readonly Type _serviceType;
        private readonly IServiceProvider _serviceProvider;
        private ObjectFactory _factory;

        public WeaklyTypedFactory(Type serviceType, IServiceProvider serviceProvider)
        {
            _serviceType = serviceType;
            _serviceProvider = serviceProvider;
        }

        public object CreateService(params object[] arguments)
        {
            if (_factory == null)
            {
                var argumentTypes = arguments.Select(p => p.GetType()).ToArray();
                _factory = ActivatorUtilities.CreateFactory(_serviceType, argumentTypes);
            }

            var instance = _factory.Invoke(_serviceProvider, arguments);
            return instance;
        }
    }

    internal class WeaklyTypedFactory<TService, TImplementation> : WeaklyTypedFactory, IWeaklyTypedFactory<TService>
        where TService : class
        where TImplementation : class, TService
    {
        public WeaklyTypedFactory(IServiceProvider serviceProvider) : base(typeof(TImplementation), serviceProvider)
        {
        }

        public new TService CreateService(params object[] arguments)
        {
            return (TService)base.CreateService(arguments);
        }
    }
}