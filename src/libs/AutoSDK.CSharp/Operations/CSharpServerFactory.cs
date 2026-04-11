using System.Collections.Immutable;
using System.Text;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

internal static class CSharpServerFactory
{
    public static EquatableArray<ServerOption> CreateServerOptions(
        IList<OpenApiServer>? servers)
    {
        if (servers == null || servers.Count == 0)
        {
            return [];
        }

        var builder = ImmutableArray.CreateBuilder<ServerOption>(servers.Count);
        var seenUrls = new HashSet<string>(StringComparer.Ordinal);
        var seenIds = new HashSet<string>(StringComparer.Ordinal);

        foreach (var server in servers)
        {
            if (server == null)
            {
                continue;
            }

            var url = server.ExpandServerTemplate().Trim();
            if (string.IsNullOrWhiteSpace(url) || !seenUrls.Add(url))
            {
                continue;
            }

            var id = GetServerId(server, url);
            if (!seenIds.Add(id))
            {
                var suffix = 2;
                var candidate = id;
                while (!seenIds.Add(candidate))
                {
                    candidate = $"{id}-{suffix++}";
                }

                id = candidate;
            }

            builder.Add(new ServerOption(
                Id: id,
                Name: GetServerName(server, url),
                Url: url,
                Description: server.Description ?? string.Empty));
        }

        return builder.ToImmutable();
    }

    private static string GetServerId(
        OpenApiServer server,
        string url)
    {
        if (OpenApiExtensions.TryGetExtensionStringValue(server.Extensions, "x-server-id", out var explicitId) &&
            !string.IsNullOrWhiteSpace(explicitId))
        {
            return SanitizeToken(explicitId);
        }

        return Uri.TryCreate(url, UriKind.Absolute, out var uri)
            ? SanitizeToken($"{uri.Scheme}-{uri.Host}{uri.AbsolutePath}")
            : SanitizeToken(url);
    }

    private static string GetServerName(
        OpenApiServer server,
        string url)
    {
        if (OpenApiExtensions.TryGetExtensionStringValue(server.Extensions, "x-server-name", out var explicitName) &&
            !string.IsNullOrWhiteSpace(explicitName))
        {
            return explicitName.Trim();
        }

        if (!string.IsNullOrWhiteSpace(server.Description))
        {
            return (server.Description ?? string.Empty).Trim();
        }

        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            var path = uri.AbsolutePath.Trim('/').Replace('/', ' ');
            return string.IsNullOrWhiteSpace(path)
                ? uri.Host
                : $"{uri.Host} {path}";
        }

        return url;
    }

    private static string SanitizeToken(string value)
    {
        value = value ?? throw new ArgumentNullException(nameof(value));

        var builder = new StringBuilder(value.Length);
        var previousWasDash = false;

        foreach (var c in value)
        {
            if (char.IsLetterOrDigit(c))
            {
                builder.Append(char.ToLowerInvariant(c));
                previousWasDash = false;
            }
            else if (!previousWasDash)
            {
                builder.Append('-');
                previousWasDash = true;
            }
        }

        var token = builder.ToString().Trim('-');
        return string.IsNullOrWhiteSpace(token)
            ? "server"
            : token;
    }
}
