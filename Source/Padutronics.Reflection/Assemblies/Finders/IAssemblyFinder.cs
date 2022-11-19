using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Assemblies.Finders;

public interface IAssemblyFinder
{
    IEnumerable<Assembly> FindAssemblies();
}