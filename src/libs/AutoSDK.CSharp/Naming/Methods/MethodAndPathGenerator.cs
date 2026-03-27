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

        var path = MethodAndPathNameHelper.StripCommonPrefixes(operation.OperationPath);

        path = path.Replace("{", "{By{");

        return $"{prefix}{path.TrimStart('/').ToPropertyName().UseWordSeparator(CSharpMethodNamingSeparators.PathSeparators)}";
    }

    public static string DeriveNameFromMethodAndPath(string httpMethod, string operationPath)
        => MethodAndPathNameHelper.DeriveNameFromMethodAndPath(httpMethod, operationPath);
}
