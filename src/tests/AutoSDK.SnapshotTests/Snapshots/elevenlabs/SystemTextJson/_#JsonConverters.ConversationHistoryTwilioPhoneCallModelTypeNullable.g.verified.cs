//HintName: JsonConverters.ConversationHistoryTwilioPhoneCallModelTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistoryTwilioPhoneCallModelTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConversationHistoryTwilioPhoneCallModelType?>
    {
        /// <inheritdoc />
        public override global::G.ConversationHistoryTwilioPhoneCallModelType? Read(
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
                        return global::G.ConversationHistoryTwilioPhoneCallModelTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConversationHistoryTwilioPhoneCallModelType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConversationHistoryTwilioPhoneCallModelType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConversationHistoryTwilioPhoneCallModelType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ConversationHistoryTwilioPhoneCallModelTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
