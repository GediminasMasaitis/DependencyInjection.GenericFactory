// This file is auto-generated! Edit Factory.tt instead
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GenericFactory.Tests")]
namespace GenericFactory
{
    internal class DelegateFactory<TService>
        : IFactory<TService>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService()
        {
            return _factoryFunction.Invoke(_provider);
        }
    }

    internal class DelegateFactory<TService, TArg1>
        : IFactory<TService, TArg1>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1)
        {
            return _factoryFunction.Invoke(_provider, arg1);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2>
        : IFactory<TService, TArg1, TArg2>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3>
        : IFactory<TService, TArg1, TArg2, TArg3>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }
    }

    internal class DelegateFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
        : IFactory<TService, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
        where TService : class
    {
        private readonly IServiceProvider _provider;
        private readonly Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TService> _factoryFunction;

        public DelegateFactory(IServiceProvider provider, Func<IServiceProvider, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TService> factoryFunction)
        {
            _provider = provider;
            _factoryFunction = factoryFunction;
        }

        public TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            return _factoryFunction.Invoke(_provider, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }
    }

}
