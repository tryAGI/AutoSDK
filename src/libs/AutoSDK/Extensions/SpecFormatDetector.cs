using System.Text.RegularExpressions;

namespace AutoSDK.Extensions;

/// <summary>
/// Detects whether a specification text is OpenAPI or AsyncAPI format.
/// </summary>
public static class SpecFormatDetector
{
    public const string GrpcProtoPipelineNotSupportedMessage =
        "gRPC .proto inputs are not supported by AutoSDK's OpenAPI/AsyncAPI pipeline. " +
        "Use `autosdk generate <file.proto>` to scaffold a C# gRPC client project, or use standard gRPC tooling directly.";

    public const string GrpcProtoCommandNotSupportedMessage =
        "gRPC .proto inputs are not supported by this command. " +
        "Use `autosdk generate <file.proto>` to scaffold a C# gRPC client project instead.";

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

        if (LooksLikeGrpcProto(text))
        {
            return SpecFormat.GrpcProto;
        }

        return SpecFormat.OpenApi;
    }

    private static bool LooksLikeGrpcProto(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        if (Regex.IsMatch(
                text,
                @"^\s*syntax\s*=\s*[""']proto(?:2|3)?[""']\s*;",
                RegexOptions.Multiline | RegexOptions.CultureInvariant))
        {
            return true;
        }

        return Regex.IsMatch(
                   text,
                   @"^\s*service\s+\w+\s*\{",
                   RegexOptions.Multiline | RegexOptions.CultureInvariant) &&
               Regex.IsMatch(
                   text,
                   @"^\s*rpc\s+\w+\s*\(",
                   RegexOptions.Multiline | RegexOptions.CultureInvariant);
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

    /// <summary>
    /// gRPC Protocol Buffers definition (.proto).
    /// </summary>
    GrpcProto,
}
