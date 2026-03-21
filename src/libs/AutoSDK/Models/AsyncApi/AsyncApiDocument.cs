using System.Text.Json.Nodes;

namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents a parsed AsyncAPI document.
/// </summary>
public sealed class AsyncApiDocument
{
    /// <summary>
    /// The AsyncAPI specification version (e.g., "3.0.0").
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// General information about the API.
    /// </summary>
    public AsyncApiInfo Info { get; set; } = new();

    /// <summary>
    /// Server connection information.
    /// </summary>
    public Dictionary<string, AsyncApiServer> Servers { get; set; } = new();

    /// <summary>
    /// Channels (endpoints) for communication.
    /// </summary>
    public Dictionary<string, AsyncApiChannel> Channels { get; set; } = new();

    /// <summary>
    /// Operations that can be performed.
    /// </summary>
    public Dictionary<string, AsyncApiOperation> Operations { get; set; } = new();

    /// <summary>
    /// Reusable components (schemas, messages, etc.).
    /// </summary>
    public AsyncApiComponents Components { get; set; } = new();
}

/// <summary>
/// General information about the API.
/// </summary>
public sealed class AsyncApiInfo
{
    public string Title { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// Reusable components defined in the AsyncAPI document.
/// </summary>
public sealed class AsyncApiComponents
{
    /// <summary>
    /// Reusable schema definitions (JSON Schema).
    /// </summary>
    public Dictionary<string, JsonNode> Schemas { get; set; } = new();

    /// <summary>
    /// Reusable message definitions.
    /// </summary>
    public Dictionary<string, AsyncApiMessage> Messages { get; set; } = new();

    /// <summary>
    /// Reusable security scheme definitions.
    /// </summary>
    public Dictionary<string, AsyncApiSecurityScheme> SecuritySchemes { get; set; } = new();

    /// <summary>
    /// Reusable operation trait definitions.
    /// </summary>
    public Dictionary<string, AsyncApiOperationTrait> OperationTraits { get; set; } = new();
}
