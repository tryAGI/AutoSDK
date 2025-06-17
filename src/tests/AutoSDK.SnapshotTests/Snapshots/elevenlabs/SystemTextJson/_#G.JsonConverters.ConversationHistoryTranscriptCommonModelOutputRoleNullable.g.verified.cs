//HintName: G.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConversationHistoryTranscriptCommonModelOutputRole?>
    {
        /// <inheritdoc />
        public override global::G.ConversationHistoryTranscriptCommonModelOutputRole? Read(
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
                        return global::G.ConversationHistoryTranscriptCommonModelOutputRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConversationHistoryTranscriptCommonModelOutputRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConversationHistoryTranscriptCommonModelOutputRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConversationHistoryTranscriptCommonModelOutputRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ConversationHistoryTranscriptCommonModelOutputRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
