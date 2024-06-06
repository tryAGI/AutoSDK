//HintName: JsonSerializerContextConverters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed partial class JsonSerializerContextConverters
    {
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::OpenApiGenerator.JsonConverters.GenerateCompletionRequestFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateCompletionRequestFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateChatCompletionRequestFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateChatCompletionRequestFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelResponseStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelResponseStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelResponseStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelResponseStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelResponseStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelResponseStatusNullableJsonConverter(),
                }
            }; 
    }
}