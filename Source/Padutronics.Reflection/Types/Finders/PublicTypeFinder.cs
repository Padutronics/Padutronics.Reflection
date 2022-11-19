using System;
using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Types.Finders;

public sealed class PublicTypeFinder : ITypeFinder
{
    public IEnumerable<Type> FindTypes(Assembly assembly)
    {
        return assembly.GetExportedTypes();
    }
}