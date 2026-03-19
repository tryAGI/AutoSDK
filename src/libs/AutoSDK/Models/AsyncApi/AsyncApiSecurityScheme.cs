namespace AutoSDK.Models.AsyncApi;

/// <summary>
/// Represents a security scheme in an AsyncAPI document.
/// </summary>
public sealed class AsyncApiSecurityScheme
{
    /// <summary>
    /// The type of security scheme (e.g., "http", "apiKey", "httpApiKey").
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// The scheme (e.g., "bearer", "basic"). Used with type "http".
    /// </summary>
    public string Scheme { get; set; } = string.Empty;

    /// <summary>
    /// The name of the header/query parameter. Used with type "apiKey" or "httpApiKey".
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The location of the API key: "header" or "query".
    /// </summary>
    public string In { get; set; } = string.Empty;

    /// <summary>
    /// Description of the security scheme.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
