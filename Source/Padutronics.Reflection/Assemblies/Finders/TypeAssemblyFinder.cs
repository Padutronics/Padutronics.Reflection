using System;
using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Assemblies.Finders;

public sealed class TypeAssemblyFinder : IAssemblyFinder
{
    private readonly Lazy<IEnumerable<Assembly>> assemblies;

    public TypeAssemblyFinder(Type type)
    {
        assemblies = new Lazy<IEnumerable<Assembly>>(() => FindAssemblies(type));
    }

    public IEnumerable<Assembly> FindAssemblies()
    {
        return assemblies.Value;
    }

    private IEnumerable<Assembly> FindAssemblies(Type type)
    {
        return new[] { type.Assembly };
    }
}