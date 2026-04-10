using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateServerSelectionSupport(
        CSharpSettings settings)
    {
        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Represents a concrete OpenAPI server option.
    /// </summary>
    public sealed class AutoSDKServer
    {{
        public AutoSDKServer(
            string id,
            string name,
            string url,
            string description)
        {{
            Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            Name = name ?? string.Empty;
            Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            Description = description ?? string.Empty;
            Uri = new global::System.Uri(url, global::System.UriKind.RelativeOrAbsolute);
        }}

        public string Id {{ get; }}
        public string Name {{ get; }}
        public string Url {{ get; }}
        public string Description {{ get; }}
        public global::System.Uri Uri {{ get; }}
    }}

    internal sealed class AutoSDKServerConfiguration
    {{
        public global::System.Uri? ExplicitBaseUri {{ get; set; }}
        public global::{settings.Namespace}.AutoSDKServer? SelectedServer {{ get; set; }}
    }}
}}";
    }

    private static string GenerateServerDeclarations(
        EquatableArray<ServerOption> servers,
        string @namespace,
        int level)
    {
        return servers.Select(server => $@"
{new string(' ', level)}new global::{@namespace}.AutoSDKServer(
{new string(' ', level + 4)}id: ""{EscapeCSharpStringLiteral(server.Id)}"",
{new string(' ', level + 4)}name: ""{EscapeCSharpStringLiteral(server.Name)}"",
{new string(' ', level + 4)}url: ""{EscapeCSharpStringLiteral(server.Url)}"",
{new string(' ', level + 4)}description: ""{EscapeCSharpStringLiteral(server.Description)}""),").Inject();
    }

    private static string EscapeCSharpStringLiteral(string? value)
    {
        return (value ?? string.Empty)
            .Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\r", "\\r")
            .Replace("\n", "\\n");
    }
}
