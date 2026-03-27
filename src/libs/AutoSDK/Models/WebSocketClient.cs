using System.Collections.Immutable;

namespace AutoSDK.Models;

/// <summary>
/// Represents a generated WebSocket client class.
/// </summary>
public record struct WebSocketClient(
    string Id,
    string ClassName,
    string FileNameWithoutExtension,
    string InterfaceFileNameWithoutExtension,
    string BaseUrl,
    string Protocol,
    EquatableArray<WebSocketEndPoint> SendOperations,
    EquatableArray<WebSocketEndPoint> ReceiveOperations,
    EquatableArray<Authorization> Authorizations,
    EquatableArray<MethodParameter> QueryParameters,
    EquatableArray<MethodParameter> SerializedQueryParameters,
    string Summary,
    Settings Settings,
    Settings GlobalSettings,
    ImmutableArray<string> Converters)
{
    /// <summary>
    /// The base event type for all received events (the first receive message type if only one,
    /// or a discriminated union type if multiple).
    /// </summary>
    public TypeData BaseReceiveEventType { get; set; }

    /// <summary>
    /// Whether the base receive event type is a value type (struct/anyOf).
    /// When true, the null-coalescing pattern (?? throw) cannot be used in deserialization.
    /// </summary>
    public bool IsReceiveEventValueType { get; set; }
}
