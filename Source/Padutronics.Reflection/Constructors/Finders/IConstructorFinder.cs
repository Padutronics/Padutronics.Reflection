using System;
using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Constructors.Finders;

public interface IConstructorFinder
{
    IEnumerable<ConstructorInfo> FindConstructors(Type type);
}