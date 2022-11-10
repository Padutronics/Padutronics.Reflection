using System;

namespace Padutronics.Reflection.Types;

public static class TypeArray
{
    public static Type[] Create<T>()
    {
        return new[] { typeof(T) };
    }

    public static Type[] Create<T1, T2>()
    {
        return new[] { typeof(T1), typeof(T2) };
    }

    public static Type[] Create<T1, T2, T3>()
    {
        return new[] { typeof(T1), typeof(T2), typeof(T3) };
    }

    public static Type[] Create<T1, T2, T3, T4>()
    {
        return new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) };
    }

    public static Type[] Create<T1, T2, T3, T4, T5>()
    {
        return new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) };
    }
}