//HintName: G.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionRequestMessageContentPartRefusalType?>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionRequestMessageContentPartRefusalType? Read(
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
                        return global::G.ChatCompletionRequestMessageContentPartRefusalTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatCompletionRequestMessageContentPartRefusalType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ChatCompletionRequestMessageContentPartRefusalType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionRequestMessageContentPartRefusalType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ChatCompletionRequestMessageContentPartRefusalTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
