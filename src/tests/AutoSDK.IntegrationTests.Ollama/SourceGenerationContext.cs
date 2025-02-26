using System.Text.Json.Serialization;

namespace AutoSDK.IntegrationTests;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(JsonSerializerContextTypes))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;