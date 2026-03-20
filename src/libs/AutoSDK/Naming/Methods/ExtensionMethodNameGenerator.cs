using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

/// <summary>
/// Generates method names from OpenAPI x-extensions:
/// - x-fern-sdk-method-name: Clean, human-chosen method names (used by Cohere, AssemblyAI, ElevenLabs, Vectara)
/// - x-oaiMeta.name: Method name from OpenAI metadata
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

        // Try x-fern-sdk-method-name first
        if (OpenApiExtensions.TryGetExtensionStringValue(
                extensions, "x-fern-sdk-method-name", out var fernMethodName) &&
            !string.IsNullOrWhiteSpace(fernMethodName))
        {
            return fernMethodName
                .ToPropertyName()
                .UseWordSeparator('\\', '-', '.', '_', '/', '}', '{', '<', '>', ' ', '(', ')');
        }

        // Try x-oaiMeta.name (OpenAI metadata)
        if (extensions.TryGetValue("x-oaiMeta", out var oaiMetaExt) &&
            OpenApiExtensions.TryGetExtensionJsonNode(oaiMetaExt) is JsonObject oaiMetaObj &&
            oaiMetaObj.TryGetPropertyValue("name", out var nameNode) &&
            nameNode is JsonValue nameValue &&
            nameValue.TryGetValue<string>(out var oaiName) &&
            !string.IsNullOrWhiteSpace(oaiName))
        {
            return oaiName
                .ToPropertyName()
                .UseWordSeparator('\\', '-', '.', '_', '/', '}', '{', '<', '>', ' ', '(', ')');
        }

        return null;
    }
}
