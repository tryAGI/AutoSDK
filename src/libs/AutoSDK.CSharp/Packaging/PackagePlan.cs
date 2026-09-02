using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace AutoSDK.Packaging;

/// <summary>
/// The deterministic package graph produced from an OpenAPI document's tags, plus the mapping that
/// routes every generated file into exactly one package.
/// </summary>
/// <param name="BasePackageId">Package id of the facade, e.g. <c>tryAGI.GitHub</c>.</param>
/// <param name="Namespace">C# namespace shared by every package in the family.</param>
/// <param name="TargetFramework">Target framework every generated project uses.</param>
/// <param name="RootClientFilePrefixes">
/// File-name prefixes identifying partials of the root client class. The root client's own files
/// use the dot-stripped class name while the authorization partials use the raw
/// <c>Settings.ClassName</c>, so both forms are carried here.
/// </param>
/// <param name="Packages">Core first, then tag packages ordered by id, then the facade.</param>
/// <param name="FileToPackageId">Generated file name to owning package id, for files whose owner is known exactly.</param>
public record struct PackagePlan(
    string BasePackageId,
    string Namespace,
    string TargetFramework,
    ImmutableArray<string> RootClientFilePrefixes,
    ImmutableArray<PackageDescriptor> Packages,
    IReadOnlyDictionary<string, string> FileToPackageId)
{
    /// <summary>
    /// The shared package every other package in the family references.
    /// </summary>
    public PackageDescriptor Core => Packages.First(static x => x.Kind == PackageKind.Core);

    /// <summary>
    /// The base package that reassembles the full-SDK experience.
    /// </summary>
    public PackageDescriptor Facade => Packages.First(static x => x.Kind == PackageKind.Facade);

    /// <summary>
    /// Per-tag packages, ordered by package id.
    /// </summary>
    public IEnumerable<PackageDescriptor> TagPackages => Packages.Where(static x => x.Kind == PackageKind.Tag);

    /// <summary>
    /// Routes one generated file to its owning package.
    /// </summary>
    /// <remarks>
    /// Files whose owner is derivable from the model (tag clients, tag interfaces and their
    /// operation partials) are resolved from <see cref="FileToPackageId"/>. Anything that is a
    /// partial of the root client class goes to the facade, because C# partial types cannot span
    /// assemblies. Everything else — models, enums, unions, converters, the JSON serializer
    /// context and the runtime support types — is shared, so it goes to Core.
    /// </remarks>
    public string ResolvePackageId(string fileName)
    {
        fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));

        if (FileToPackageId.TryGetValue(fileName, out var packageId))
        {
            return packageId;
        }

        foreach (var prefix in RootClientFilePrefixes)
        {
            if (fileName.StartsWith(prefix, StringComparison.Ordinal))
            {
                return BasePackageId;
            }
        }

        return Core.PackageId;
    }
}
