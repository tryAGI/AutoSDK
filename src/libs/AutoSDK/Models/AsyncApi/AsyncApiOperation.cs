namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents an operation in an AsyncAPI document.
/// </summary>
public sealed class AsyncApiOperation
{
    /// <summary>
    /// The action: "send" (client→server) or "receive" (server→client).
    /// </summary>
    public string Action { get; set; } = string.Empty;

    /// <summary>
    /// Reference to the channel this operation uses (e.g., "$ref: '#/channels/realtime'").
    /// </summary>
    public string ChannelRef { get; set; } = string.Empty;

    /// <summary>
    /// The resolved channel name (extracted from $ref).
    /// </summary>
    public string ChannelName { get; set; } = string.Empty;

    /// <summary>
    /// Summary/title of the operation.
    /// </summary>
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// Description of the operation.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Messages associated with this operation.
    /// </summary>
    public List<AsyncApiOperationMessage> Messages { get; set; } = new();

    /// <summary>
    /// Whether this is a send (client→server) operation.
    /// </summary>
    public bool IsSend => string.Equals(Action, "send", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Whether this is a receive (server→client) operation.
    /// </summary>
    public bool IsReceive => string.Equals(Action, "receive", StringComparison.OrdinalIgnoreCase);
}

/// <summary>
/// A message reference within an operation.
/// </summary>
public sealed class AsyncApiOperationMessage
{
    /// <summary>
    /// Reference path (e.g., "#/channels/realtime/messages/input_audio_chunk").
    /// </summary>
    public string Ref { get; set; } = string.Empty;
}
