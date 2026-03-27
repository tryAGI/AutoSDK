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
}
