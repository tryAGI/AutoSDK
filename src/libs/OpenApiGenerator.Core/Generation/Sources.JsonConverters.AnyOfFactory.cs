using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateAnyOfJsonConverterFactory(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var (subType, count, jsonSerializerType) = anyOfData;
        if (jsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return string.Empty;
        }
        
        var types = $"<{string.Join(",", Enumerable.Range(1, count).Select(_ => string.Empty))}>";

        return $@"#nullable enable

namespace OpenApiGenerator.JsonConverters
{{
    public sealed class {subType}JsonConverterFactory{count} : global::System.Text.Json.Serialization.JsonConverterFactory
    {{
        public override bool CanConvert(global::System.Type? typeToConvert)
        {{
            return typeToConvert is {{ IsGenericType: true }} && typeToConvert.GetGenericTypeDefinition() == typeof(global::System.{subType}{types});
        }}

        public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            typeToConvert = typeToConvert ?? throw new global::System.ArgumentNullException(nameof(typeToConvert));
        
            return (global::System.Text.Json.Serialization.JsonConverter)global::System.Activator.CreateInstance(
                typeof({subType}JsonConverter{types}).MakeGenericType(typeToConvert.GenericTypeArguments))!;
        }}
    }}
}}
";
    }
}