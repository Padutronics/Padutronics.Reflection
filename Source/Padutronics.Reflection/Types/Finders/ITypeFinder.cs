using System;
using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Types.Finders;

public interface ITypeFinder
{
    IEnumerable<Type> FindTypes(Assembly assembly);
}