//HintName: G.JsonConverters.ChatStreamEndEventVariant2FinishReasonNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatStreamEndEventVariant2FinishReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatStreamEndEventVariant2FinishReason?>
    {
        /// <inheritdoc />
        public override global::G.ChatStreamEndEventVariant2FinishReason? Read(
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
                        return global::G.ChatStreamEndEventVariant2FinishReasonExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatStreamEndEventVariant2FinishReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ChatStreamEndEventVariant2FinishReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatStreamEndEventVariant2FinishReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ChatStreamEndEventVariant2FinishReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
