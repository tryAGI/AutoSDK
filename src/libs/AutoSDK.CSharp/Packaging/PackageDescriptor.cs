using System.Collections.Immutable;

namespace AutoSDK.Packaging;

/// <summary>
/// One project/package inside a split-by-tags family.
/// </summary>
/// <param name="PackageId">NuGet package id, also the project file name and the assembly name.</param>
/// <param name="Kind">The role this package plays in the family.</param>
/// <param name="Tags">
/// OpenAPI tag names owned by this package, ordered ordinally. Empty for
/// <see cref="PackageKind.Core"/>; empty for <see cref="PackageKind.Facade"/> because untagged
/// operations have no tag name to report.
/// </param>
/// <param name="ClientClassNames">Generated client classes that live in this package, ordered ordinally.</param>
public record struct PackageDescriptor(
    string PackageId,
    PackageKind Kind,
    ImmutableArray<string> Tags,
    ImmutableArray<string> ClientClassNames)
{
    /// <summary>
    /// Directory name under the packages root. Identical to <see cref="PackageId"/> so the tree
    /// is trivially mappable back to NuGet ids.
    /// </summary>
    public string DirectoryName => PackageId;
}
