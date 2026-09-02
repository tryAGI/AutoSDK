namespace AutoSDK.Packaging;

/// <summary>
/// The role a generated project plays inside a split-by-tags package family.
/// </summary>
public enum PackageKind
{
    /// <summary>
    /// Shared models, unions, converters, the JSON serializer context and the runtime support
    /// types. Every other package in the family references it, and it references none of them.
    /// </summary>
    Core,

    /// <summary>
    /// One OpenAPI tag's client, its interface and its operation partials. References
    /// <see cref="Core"/> only.
    /// </summary>
    Tag,

    /// <summary>
    /// The base package: the root client that exposes every tag client as a property, its
    /// authorization partials, dependency-injection extensions and any untagged operations.
    /// References <see cref="Core"/> and every <see cref="Tag"/> package.
    /// </summary>
    Facade,
}
