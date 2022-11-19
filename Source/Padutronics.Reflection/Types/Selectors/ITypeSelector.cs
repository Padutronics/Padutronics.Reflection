using System;
using System.Collections.Generic;

namespace Padutronics.Reflection.Types.Selectors;

public interface ITypeSelector
{
    IEnumerable<Type> SelectTypes(IEnumerable<Type> types);
}