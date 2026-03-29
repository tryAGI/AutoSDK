//HintName: G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType?>
    {
        /// <inheritdoc />
        public override global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType? Read(
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
                        return global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
