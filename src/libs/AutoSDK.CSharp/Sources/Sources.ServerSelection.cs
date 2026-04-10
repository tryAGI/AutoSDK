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
        /// <summary>
        /// Initializes a new instance of the <see cref=""AutoSDKServer""/> class.
        /// </summary>
        /// <param name=""id"">The stable identifier for this server option.</param>
        /// <param name=""name"">The display name for this server option.</param>
        /// <param name=""url"">The server URL.</param>
        /// <param name=""description"">The server description.</param>
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

        /// <summary>
        /// Gets the stable identifier for this server option.
        /// </summary>
        public string Id {{ get; }}
        /// <summary>
        /// Gets the display name for this server option.
        /// </summary>
        public string Name {{ get; }}
        /// <summary>
        /// Gets the server URL.
        /// </summary>
        public string Url {{ get; }}
        /// <summary>
        /// Gets the server description.
        /// </summary>
        public string Description {{ get; }}
        /// <summary>
        /// Gets the parsed server URI.
        /// </summary>
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
