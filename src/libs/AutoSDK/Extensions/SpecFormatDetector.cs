namespace AutoSDK.Extensions;

/// <summary>
/// Detects whether a specification text is OpenAPI or AsyncAPI format.
/// </summary>
public static class SpecFormatDetector
{
    /// <summary>
    /// Detects the format of the given specification text.
    /// </summary>
    public static SpecFormat DetectFormat(string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        // Check for AsyncAPI markers in both YAML and JSON formats
        if (text.Contains("asyncapi:", StringComparison.OrdinalIgnoreCase) ||
            text.Contains("\"asyncapi\"", StringComparison.OrdinalIgnoreCase))
        {
            return SpecFormat.AsyncApi;
        }

        return SpecFormat.OpenApi;
    }
}

/// <summary>
/// The format of an API specification.
/// </summary>
public enum SpecFormat
{
    /// <summary>
    /// OpenAPI (REST/HTTP) specification.
    /// </summary>
    OpenApi,

    /// <summary>
    /// AsyncAPI (event-driven/WebSocket) specification.
    /// </summary>
    AsyncApi,
}
