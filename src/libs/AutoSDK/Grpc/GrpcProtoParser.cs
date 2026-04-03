using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace AutoSDK.Grpc;

public static class GrpcProtoParser
{
    private static readonly Regex BlockCommentRegex = new(
        @"/\*.*?\*/",
        RegexOptions.Singleline | RegexOptions.CultureInvariant);

    private static readonly Regex LineCommentRegex = new(
        @"//.*?$",
        RegexOptions.Multiline | RegexOptions.CultureInvariant);

    private static readonly Regex ImportRegex = new(
        @"^\s*import\s+(?:public\s+|weak\s+)?""(?<path>[^""]+)""\s*;",
        RegexOptions.Multiline | RegexOptions.CultureInvariant);

    private static readonly Regex PackageRegex = new(
        @"^\s*package\s+(?<package>[A-Za-z_][\w.]*)\s*;",
        RegexOptions.Multiline | RegexOptions.CultureInvariant);

    private static readonly Regex CSharpNamespaceRegex = new(
        @"^\s*option\s+csharp_namespace\s*=\s*""(?<namespace>[^""]+)""\s*;",
        RegexOptions.Multiline | RegexOptions.CultureInvariant);

    private static readonly Regex ServiceRegex = new(
        @"^\s*service\s+(?<service>[A-Za-z_]\w*)\s*\{",
        RegexOptions.Multiline | RegexOptions.CultureInvariant);

    public static GrpcProtoDocument Parse(string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        var sanitized = StripComments(text);
        var imports = ImmutableArray.CreateBuilder<string>();
        var importSet = new HashSet<string>(StringComparer.Ordinal);
        foreach (Match match in ImportRegex.Matches(sanitized))
        {
            var path = match.Groups["path"].Value;
            if (!string.IsNullOrWhiteSpace(path) && importSet.Add(path))
            {
                imports.Add(path);
            }
        }

        var services = ImmutableArray.CreateBuilder<string>();
        var serviceSet = new HashSet<string>(StringComparer.Ordinal);
        foreach (Match match in ServiceRegex.Matches(sanitized))
        {
            var service = match.Groups["service"].Value;
            if (!string.IsNullOrWhiteSpace(service) && serviceSet.Add(service))
            {
                services.Add(service);
            }
        }

        return new GrpcProtoDocument(
            MatchSingleValue(PackageRegex, sanitized, "package"),
            MatchSingleValue(CSharpNamespaceRegex, sanitized, "namespace"),
            imports.ToImmutable(),
            services.ToImmutable());
    }

    private static string StripComments(string text)
    {
        return LineCommentRegex.Replace(BlockCommentRegex.Replace(text, string.Empty), string.Empty);
    }

    private static string? MatchSingleValue(
        Regex regex,
        string text,
        string groupName)
    {
        var match = regex.Match(text);
        if (!match.Success)
        {
            return null;
        }

        var value = match.Groups[groupName].Value;
        return string.IsNullOrWhiteSpace(value) ? null : value;
    }
}
