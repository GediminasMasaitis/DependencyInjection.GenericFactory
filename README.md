# DependencyInjection.GenericFactory ![GitHub](https://img.shields.io/github/license/GediminasMasaitis/DependencyInjection.GenericFactory) ![Nuget](https://img.shields.io/nuget/v/DependencyInjection.GenericFactory )

This library is an extension for `Microsoft.Extensions.DependencyInjection` that allows easy registration and use of DI factories that allow for runtime dependency resolution while retaining strong typing.

## Usage
The central piece is the `IFactory` generic interface, which has many versions with different counts of generic parameters. For example, for two runtime resolved parameters you would use `IFactory<TService, TArg1, TArg2>`.

Factories can be registered using `IServiceCollection.AddFactory<TService, TImplementation, TArg1, TArg2>()`, or if you need specific control on how the service is being created, you can register a factory delegate via `IServiceCollection.AddFactory<TService. TArg1, TArg2>(Func<IServiceProvider, TArg1, TArg2, TService>)`. Both methods will register a factory which will be registered to the ServiceCollection via the `IFactory` interface.

Factories can then be resolved by regular dependancy injection methods, or by calling `IServiceProvider.GetFactory<TService, Arg1, Arg2>()`. A `GetRequiredFactory` version is also available.

## When to use `IFactory<T>` instead of `IServiceProvider`?
The rule of thumb should be to always prefer using `IServiceProvider`, unless:

* Your service has dependencies that cannot be known during service registration
* You want to be explicit that *I will only create instances of this specific type*

## Example:
``` csharp
// In this example we register a NumberLoggingService and a Logger to the dependency injection container, and an OtherService (that will be using our number logger). The logger will be resolved will be resolved from a service container, and the number is passed as a parameter to the factory during runtime and is supplied to the constructor of the NumberLoggingService.

class Startup
{
    public IServiceCollection RegisterServices(IServiceCollection services)
    {
        services.AddSingleton<ILogger, Logger>();
        services.AddSingleton<OtherService>();
        services.AddFactory<INumberLoggingService, NumberLoggingService, IRuntimeDependency>();
    }

    // ...
}

interface IFooService {}

class NumberLoggingService : INumberLoggingService
{
    private readonly ILogger _logger;
    private readonly int _number;

    public FooService(ILogger logger, int number)
    {
        _logger = logger;
        _number = number;
    }

    public void Log()
    {
        _logger.Log("The number is" + _number);
    }
}

class OtherService
{
    private IFactory<INumberLoggingService, int> _factory;

    public OtherService(IFactory<INumberLoggingService, int> factory)
    {
        _factory = factory;
    }

    public void Run()
    {
        var numberLogger = _factory.CreateService(42);
        numberLogger.Log(); // "The number is 42"
    }
}
```

## Why not [`ActivatorUtilities.CreateInstance`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.activatorutilities.createinstance)?

* It's a static class that can't be injected, and can't be mocked
* It's *comparatively* slow
* It's weakly typed

In fact, the library internally uses a `WeaklyTypedFactory<TService>`, which is basically a caching wrapper around `ActivatorUtilities.CreateFactory` that gets registered as a singleton, and solves the first two problems. The `GenericFactory` is then a wrapper around that, that solves the last problem *sort of*.

*Sidenote: The weakly typed factory can be registered by calling `IServiceCollection.AddWeaklyTypedFactory<TService,TImplementation>()` and is then available via `IWeaklyTypedFactory<TService>`, but using it directly is not the recommended approach.*