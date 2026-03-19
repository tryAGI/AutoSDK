using System.Collections.Immutable;

namespace AutoSDK.Models;

/// <summary>
/// Represents a generated WebSocket client class.
/// </summary>
public record struct WebSocketClient(
    string Id,
    string ClassName,
    string BaseUrl,
    string Protocol,
    EquatableArray<WebSocketEndPoint> SendOperations,
    EquatableArray<WebSocketEndPoint> ReceiveOperations,
    EquatableArray<Authorization> Authorizations,
    string Summary,
    Settings Settings,
    Settings GlobalSettings,
    ImmutableArray<string> Converters)
{
    public string FileNameWithoutExtension => $"{Settings.Namespace}.{ClassName}";

    public string InterfaceFileNameWithoutExtension => $"{Settings.Namespace}.I{ClassName}";

    /// <summary>
    /// The base event type for all received events (the first receive message type if only one,
    /// or a discriminated union type if multiple).
    /// </summary>
    public TypeData BaseReceiveEventType { get; set; }
}
