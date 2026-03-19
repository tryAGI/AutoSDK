namespace AutoSDK.Models;

/// <summary>
/// Direction of a WebSocket message.
/// </summary>
public enum WebSocketDirection
{
    /// <summary>
    /// Client sends to server.
    /// </summary>
    Send,

    /// <summary>
    /// Server sends to client (client receives).
    /// </summary>
    Receive,
}
