using System.Collections.ObjectModel;
using System.Text.Json.Nodes;

namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents a channel (endpoint) in an AsyncAPI document.
/// </summary>
public sealed class AsyncApiChannel
{
    /// <summary>
    /// The channel address/path (e.g., "/v1/speech-to-text/realtime").
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Description of the channel.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Messages that can be sent/received on this channel.
    /// Values can be direct message definitions or $ref references.
    /// </summary>
    public Dictionary<string, AsyncApiMessage> Messages { get; set; } = new();

    /// <summary>
    /// Channel parameters (path variables, query params).
    /// </summary>
    public Dictionary<string, AsyncApiParameter> Parameters { get; set; } = new();

    /// <summary>
    /// Server references for this channel (e.g., ["production", "agent"]).
    /// Extracted from $ref paths like "#/servers/production".
    /// When non-empty, the first entry determines the base URL for this channel.
    /// </summary>
    public Collection<string> ServerRefs { get; set; } = new();

    /// <summary>
    /// Query parameters from bindings.ws.query.properties, keyed by parameter name.
    /// Values are the raw JSON nodes (typically $ref or inline schemas).
    /// </summary>
    public Dictionary<string, JsonNode?> BindingsQueryProperties { get; set; } = new();

    /// <summary>
    /// Required query parameter names from bindings.ws.query.required.
    /// </summary>
    public HashSet<string> BindingsQueryRequired { get; set; } = new();
}

/// <summary>
/// Represents a channel parameter.
/// </summary>
public sealed class AsyncApiParameter
{
    public string Description { get; set; } = string.Empty;
    public string Default { get; set; } = string.Empty;
    public Collection<string> Enum { get; set; } = new();
}
