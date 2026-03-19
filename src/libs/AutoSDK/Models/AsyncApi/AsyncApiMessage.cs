using System.Text.Json.Nodes;

namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents a message in an AsyncAPI document.
/// </summary>
public sealed class AsyncApiMessage
{
    /// <summary>
    /// The message name/identifier.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Summary of the message.
    /// </summary>
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// Description of the message.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The content type (e.g., "application/json").
    /// </summary>
    public string ContentType { get; set; } = "application/json";

    /// <summary>
    /// The payload schema as a JSON node (may contain $ref).
    /// </summary>
    public JsonNode? Payload { get; set; }

    /// <summary>
    /// Reference path if this message is a $ref (e.g., "#/components/messages/InputAudioChunk").
    /// </summary>
    public string Ref { get; set; } = string.Empty;
}
