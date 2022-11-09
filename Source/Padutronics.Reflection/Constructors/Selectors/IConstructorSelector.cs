using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Constructors.Selectors;

public interface IConstructorSelector
{
    IEnumerable<ConstructorInfo> SelectConstructors(IEnumerable<ConstructorInfo> constructors);
}