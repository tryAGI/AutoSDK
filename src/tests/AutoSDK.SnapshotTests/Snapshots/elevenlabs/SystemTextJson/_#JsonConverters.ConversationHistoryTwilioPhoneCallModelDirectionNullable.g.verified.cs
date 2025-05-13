//HintName: JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistoryTwilioPhoneCallModelDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConversationHistoryTwilioPhoneCallModelDirection?>
    {
        /// <inheritdoc />
        public override global::G.ConversationHistoryTwilioPhoneCallModelDirection? Read(
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
                        return global::G.ConversationHistoryTwilioPhoneCallModelDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConversationHistoryTwilioPhoneCallModelDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConversationHistoryTwilioPhoneCallModelDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConversationHistoryTwilioPhoneCallModelDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ConversationHistoryTwilioPhoneCallModelDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
