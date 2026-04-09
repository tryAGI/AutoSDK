using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

/// <summary>
/// Generates method names from OpenAPI x-extensions:
/// - x-fern-sdk-method-name / x-oaiMeta.name: Existing naming hints used by Fern/OpenAI specs
/// - x-speakeasy-name-override / x-stainless-naming: Cross-vendor naming overrides for .NET SDKs
/// </summary>
public class ExtensionMethodNameGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var extensions = operation.Operation.Extensions;
        if (extensions == null)
        {
            return null;
        }

        if (OpenApiExtensions.TryGetMethodNameOverride(extensions, out var methodName) &&
            !string.IsNullOrWhiteSpace(methodName))
        {
            return methodName
                .ToPropertyName()
                .UseWordSeparator(CSharpMethodNamingSeparators.MethodSeparators);
        }

        return null;
    }
}
