using AutoSDK.Extensions;

namespace AutoSDK.Models;

/// <summary>
/// Represents a single WebSocket message operation (send or receive).
/// </summary>
public record struct WebSocketEndPoint(
    string Id,
    string ClassName,
    string ChannelAddress,
    WebSocketDirection Direction,
    TypeData MessageType,
    string MessageName,
    string Summary,
    Settings Settings,
    Settings GlobalSettings)
{
    public string MethodName => Direction == WebSocketDirection.Send
        ? $"Send{Id.ToPropertyName()}Async"
        : $"Receive{Id.ToPropertyName()}Async";

    public string FileNameWithoutExtension =>
        $"{Settings.Namespace}.{ClassName}.{Id.ToPropertyName()}";
}
