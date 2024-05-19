using System.Text.Json.Serialization;

namespace OpenApiGenerator.IntegrationTests;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(OpenApiGeneratorTrimmableSupport))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;