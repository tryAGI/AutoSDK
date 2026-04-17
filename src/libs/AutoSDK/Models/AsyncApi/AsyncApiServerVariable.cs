using System.Collections.ObjectModel;

namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents a server variable in an AsyncAPI document.
/// </summary>
public sealed class AsyncApiServerVariable
{
    /// <summary>
    /// Description of the variable.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Default value of the variable.
    /// </summary>
    public string Default { get; set; } = string.Empty;

    /// <summary>
    /// Allowed values for the variable.
    /// </summary>
    public Collection<string> Enum { get; set; } = new();

    /// <summary>
    /// Example values for the variable.
    /// </summary>
    public Collection<string> Examples { get; set; } = new();

    /// <summary>
    /// Resolves the preferred value for template expansion.
    /// </summary>
    public string? GetResolvedValue()
    {
        if (!string.IsNullOrWhiteSpace(Default))
        {
            return Default;
        }

        foreach (var example in Examples)
        {
            if (!string.IsNullOrWhiteSpace(example))
            {
                return example;
            }
        }

        return null;
    }
}
