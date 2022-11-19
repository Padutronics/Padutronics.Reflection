using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Assemblies.Finders;

public sealed class ConstantAssemblyFinder : IAssemblyFinder
{
    private readonly IEnumerable<Assembly> assemblies;

    public ConstantAssemblyFinder(params Assembly[] assemblies) :
        this((IEnumerable<Assembly>)assemblies)
    {
    }

    public ConstantAssemblyFinder(IEnumerable<Assembly> assemblies)
    {
        this.assemblies = assemblies;
    }

    public IEnumerable<Assembly> FindAssemblies()
    {
        return assemblies;
    }
}