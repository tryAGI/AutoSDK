using System.Text.RegularExpressions;
using AutoSDK.Extensions;

namespace AutoSDK.Naming.Methods;

public static class MethodAndPathNameHelper
{
    private static readonly Regex VersionPrefixRegex = new(@"^/v\d+(?:beta\d*)?(?=/|$)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex PathParameterRegex = new(@"\{[^}]+\}", RegexOptions.Compiled);

    public static string DeriveNameFromMethodAndPath(string httpMethod, string operationPath)
    {
        var prefix = httpMethod switch
        {
            "GET" => "Get",
            "POST" => "Create",
            "PUT" => "Put",
            "DELETE" => "Delete",
            "PATCH" => "Patch",
            "HEAD" => "Head",
            "OPTIONS" => "Options",
            "TRACE" => "Trace",
            _ => httpMethod,
        };

        var path = StripCommonPrefixes(operationPath);

        path = PathParameterRegex.Replace(path, string.Empty);
        while (path.Contains("//"))
        {
            path = path.Replace("//", "/");
        }

        return $"{prefix}{path.TrimStart('/').ToPropertyName().UseWordSeparator(StringExtensions.PathSeparators)}";
    }

    public static string StripCommonPrefixes(string path)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        path = path.TrimEnd('/');

        if (path.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
        {
            path = path.Substring(4);
        }

        var versionMatch = VersionPrefixRegex.Match(path);
        if (versionMatch.Success)
        {
            path = path.Substring(versionMatch.Length);
        }

        if (path.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
        {
            path = path.Substring(4);
        }

        return path;
    }
}
