using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Padutronics.Reflection.Constructors.Selectors;

public sealed class LongestConstructorSelector : IConstructorSelector
{
    public IEnumerable<ConstructorInfo> SelectConstructors(IEnumerable<ConstructorInfo> constructors)
    {
        IEnumerable<ConstructorInfo> selectedConstructors = Enumerable.Empty<ConstructorInfo>();

        if (constructors.Any())
        {
            int maximumParameterCount = constructors
                .Select(constructor => constructor.GetParameters().Length)
                .Max();

            selectedConstructors = constructors.Where(
                constructor => constructor.GetParameters().Length == maximumParameterCount
            );
        }

        return selectedConstructors;
    }
}