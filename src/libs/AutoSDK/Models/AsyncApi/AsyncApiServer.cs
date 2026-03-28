using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents a server in an AsyncAPI document.
/// </summary>
public sealed class AsyncApiServer
{
    /// <summary>
    /// The server host (e.g., "api.example.com").
    /// </summary>
    public string Host { get; set; } = string.Empty;

    /// <summary>
    /// The path on the host (e.g., "/v1/realtime").
    /// </summary>
    public string Pathname { get; set; } = string.Empty;

    /// <summary>
    /// The protocol (e.g., "wss", "ws").
    /// </summary>
    public string Protocol { get; set; } = string.Empty;

    /// <summary>
    /// Description of the server.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Security requirements for this server.
    /// </summary>
    public Collection<Dictionary<string, List<string>>> Security { get; set; } = new();

    /// <summary>
    /// Constructs the full WebSocket URL.
    /// </summary>
    [SuppressMessage("Design", "CA1055:Uri return values should not be strings", Justification = "Generated sources consume this helper as a plain URL string.")]
    public string GetUrl()
    {
        var host = Host.TrimEnd('/');
        var path = string.IsNullOrEmpty(Pathname) ? string.Empty : "/" + Pathname.TrimStart('/');
        return $"{Protocol}://{host}{path}";
    }

    /// <summary>
    /// Returns protocol + host without pathname, for multi-channel mode
    /// where each channel's address provides the path.
    /// </summary>
    [SuppressMessage("Design", "CA1055:Uri return values should not be strings", Justification = "Generated sources consume this helper as a plain URL string.")]
    public string GetHostUrl()
    {
        var host = Host.TrimEnd('/');
        return $"{Protocol}://{host}";
    }
}
