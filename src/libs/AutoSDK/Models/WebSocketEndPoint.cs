namespace AutoSDK.Models;

/// <summary>
/// Represents a single WebSocket message operation (send or receive).
/// </summary>
public record struct WebSocketEndPoint(
    string Id,
    string ClassName,
    string MethodName,
    string FileNameWithoutExtension,
    string ChannelAddress,
    WebSocketDirection Direction,
    TypeData MessageType,
    string MessageName,
    string Summary,
    Settings Settings,
    Settings GlobalSettings)
{
    /// <summary>
    /// When the channel's receive event is a discriminated-union type and this
    /// operation's message is one of the union variants, the property name on the
    /// union struct that exposes this variant. Empty when this operation does not
    /// participate in a synthetic union (single receive-op channels, send ops, or
    /// when the union variant could not be matched).
    /// </summary>
    public string UnionVariantPropertyName { get; set; } = string.Empty;
}
