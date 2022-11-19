using Padutronics.IO.Paths;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace Padutronics.Reflection.Assemblies.Finders;

public sealed class PathAssemblyFinder : IAssemblyFinder
{
    private readonly bool includeExecutables;
    private readonly DirectoryPath path;

    public PathAssemblyFinder(DirectoryPath path) :
        this(path, includeExecutables: false)
    {
    }

    public PathAssemblyFinder(DirectoryPath path, bool includeExecutables)
    {
        this.includeExecutables = includeExecutables;
        this.path = path;
    }

    public IEnumerable<Assembly> FindAssemblies()
    {
        IEnumerable<string> paths = GetPaths();
        foreach (string path in paths)
        {
            if (TryLoadAssembly(path, out Assembly? assembly))
            {
                yield return assembly;
            }
        }
    }

    private IEnumerable<string> GetPaths()
    {
        IEnumerable<string> assemblies = Directory.EnumerateFiles(path.ToString(), "*.dll");
        IEnumerable<string> paths = assemblies;

        if (includeExecutables)
        {
            IEnumerable<string> executables = Directory.EnumerateFiles(path.ToString(), "*.exe");

            paths = paths.Concat(executables);
        }

        return paths;
    }

    private bool TryLoadAssembly(string path, [NotNullWhen(true)] out Assembly? assembly)
    {
        string name = Path.GetFileNameWithoutExtension(path);

        try
        {
            assembly = Assembly.Load(name);
        }
        catch (Exception)
        {
            try
            {
                assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);
            }
            catch (Exception)
            {
                assembly = null;
            }
        }

        return assembly is not null;
    }
}