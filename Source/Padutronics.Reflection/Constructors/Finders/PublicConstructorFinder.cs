using System;
using System.Collections.Generic;
using System.Reflection;

namespace Padutronics.Reflection.Constructors.Finders;

public sealed class PublicConstructorFinder : IConstructorFinder
{
    public IEnumerable<ConstructorInfo> FindConstructors(Type type)
    {
        return type.GetConstructors();
    }
}