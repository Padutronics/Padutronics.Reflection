using System;
using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Types.Finders;

public sealed class AllTypeFinder : ITypeFinder
{
    public IEnumerable<Type> FindTypes(Assembly assembly)
    {
        return assembly.GetTypes();
    }
}