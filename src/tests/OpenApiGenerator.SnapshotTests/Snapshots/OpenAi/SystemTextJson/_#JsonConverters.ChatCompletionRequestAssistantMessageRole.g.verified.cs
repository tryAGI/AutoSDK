//HintName: JsonConverters.ChatCompletionRequestAssistantMessageRole.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class ChatCompletionRequestAssistantMessageRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionRequestAssistantMessageRole>
    {
        public override global::G.ChatCompletionRequestAssistantMessageRole Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.ChatCompletionRequestAssistantMessageRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.ChatCompletionRequestAssistantMessageRoleExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionRequestAssistantMessageRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ChatCompletionRequestAssistantMessageRoleExtensions.ToValueString(value));
        }
    }
}
