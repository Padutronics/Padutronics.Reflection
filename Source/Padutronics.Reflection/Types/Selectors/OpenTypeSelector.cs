using System;
using System.Collections.Generic;
using System.Linq;

namespace Padutronics.Reflection.Types.Selectors;

public sealed class OpenTypeSelector : ITypeSelector
{
    public IEnumerable<Type> SelectTypes(IEnumerable<Type> types)
    {
        return types.Where(type => type.IsGenericTypeDefinition || type.ContainsGenericParameters);
    }
}