using System.Text.Json.Serialization;

namespace OpenApiGenerator.IntegrationTests;

[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    WriteIndented = true,
    Converters = [
        typeof(JsonConverters.CreateChatCompletionRequestJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestMessageJsonConverter),
        typeof(JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter),
        typeof(JsonConverters.ModelIdsSharedEnumJsonConverter),
    ])]
[JsonSerializable(typeof(JsonSerializerContextTypes))]
[JsonSerializable(typeof(CreateChatCompletionRequest))]
[JsonSerializable(typeof(CreateChatCompletionRequestVariant2))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;
