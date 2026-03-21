using System.Text.RegularExpressions;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class MethodAndPathGenerator : IMethodNameGenerator
{
    public string TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var prefix = operation.OperationType.Method switch
        {
            "GET" => "get",
            "POST" => "create",
            "PUT" => "put",
            "DELETE" => "delete",
            "PATCH" => "edit",
            "HEAD" => "head",
            "OPTIONS" => "options",
            "TRACE" => "trace",
            _ => throw new NotSupportedException($"HttpMethod {operation.OperationType} is not supported."),
        };

        var path = StripCommonPrefixes(operation.OperationPath);

        path = path.Replace("{", "{By{");

        return $"{prefix}{path.TrimStart('/').ToPropertyName().UseWordSeparator(StringExtensions.PathSeparators)}";
    }

    /// <summary>
    /// Derives a PascalCase type name from an HTTP method and path.
    /// Used as a fallback when operationId is missing, to produce stable, descriptive
    /// request/response type names (e.g., "CreateModelsSettings" instead of "Request2").
    /// </summary>
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

        // Remove path parameters for cleaner type names
        // e.g., /models/{repo_id}/settings → /models/settings → ModelsSettings
        path = Regex.Replace(path, @"\{[^}]+\}", "");
        // Clean up double slashes from removed params
        while (path.Contains("//"))
            path = path.Replace("//", "/");

        return $"{prefix}{path.TrimStart('/').ToPropertyName().UseWordSeparator(StringExtensions.PathSeparators)}";
    }

    private static string StripCommonPrefixes(string path)
    {
        // Normalize trailing slash so /models/ and /models produce the same name
        path = path.TrimEnd('/');

        if (path.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
            path = path.Substring(4);

        // Strip version prefixes like /v1, /v2, /v3, /v1beta, /v2beta1, etc.
        var versionMatch = Regex.Match(path, @"^/v\d+(?:beta\d*)?(?=/|$)", RegexOptions.IgnoreCase);
        if (versionMatch.Success)
            path = path.Substring(versionMatch.Length);

        if (path.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
            path = path.Substring(4);

        return path;
    }
}