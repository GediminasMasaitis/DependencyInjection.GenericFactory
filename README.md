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
class Startup
{
    public IServiceCollection RegisterServices(IServiceCollection services)
    {
        services.AddFactory<IFooService, FooService, UnregisteredDependency>();
    }

    // ...
}

interface IFooService {}

class FooService : IFooService
{
    public FooService(UnregisteredDependency dependency) { }
}

class OtherService
{
    private IFactory<IFooService, IRuntimeDependency> _factory;

    public OtherService(IFactory<IFooService, IRuntimeDependency> factory)
    {
        _factory = factory;
    }

    public void Run(IRuntimeDependency runtimeDependency)
    {
        var fooService = factory.CreateService(runtimeDependency);
        // use fooService
    }
}
```

## Why not [`ActivatorUtilities.CreateInstance`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.activatorutilities.createinstance)?

* It's a static class that can't be injected, and can't be mocked
* It's *comparatively* slow
* It's weakly typed

In fact, the library internally uses a `WeaklyTypedFactory<TService>`, which is basically a caching wrapper around `ActivatorUtilities.CreateFactory` that gets registered as a singleton, and solves the first two problems. The `GenericFactory` is then a wrapper around that, that solves the last problem *sort of*.

*Sidenote: The weakly typed factory can be registered by calling `IServiceCollection.AddWeaklyTypedFactory<TService,TImplementation>()` and is then available via `IWeaklyTypedFactory<TService>`, but using it directly is not the recommended approach.*