//HintName: G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType>
    {
        /// <inheritdoc />
        public override global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType Read(
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
                        return global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeExtensions.ToValueString(value));
        }
    }
}
