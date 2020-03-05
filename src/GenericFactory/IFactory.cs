// This file is auto-generated! Edit IFactory.tt instead
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GenericFactory.Tests")]
namespace GenericFactory
{
    public interface IFactory<out TService>
    {
        TService CreateService();
    }

    public interface IFactory<out TService, in TArg1>
    {
        TService CreateService(TArg1 arg1);
    }

    public interface IFactory<out TService, in TArg1, in TArg2>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14);
    }

    public interface IFactory<out TService, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15>
    {
        TService CreateService(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15);
    }

}
