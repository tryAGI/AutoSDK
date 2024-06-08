using System.Text.Json.Serialization;

namespace OpenApiGenerator.IntegrationTests;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(JsonSerializerContextTypes))]
[JsonSerializable(typeof(Error))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;