using System.Collections.ObjectModel;

namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents a reusable operation trait in an AsyncAPI document.
/// Traits carry shared metadata (e.g., security requirements) that operations can reference.
/// </summary>
public sealed class AsyncApiOperationTrait
{
    /// <summary>
    /// Security requirements from this trait.
    /// Each item is a map of security scheme name to scopes.
    /// </summary>
    public Collection<Dictionary<string, List<string>>> Security { get; set; } = new();

    /// <summary>
    /// Description of the trait.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
