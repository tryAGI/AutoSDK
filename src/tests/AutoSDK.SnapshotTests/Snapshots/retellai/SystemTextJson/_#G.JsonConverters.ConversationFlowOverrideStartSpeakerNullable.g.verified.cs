//HintName: G.JsonConverters.ConversationFlowOverrideStartSpeakerNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationFlowOverrideStartSpeakerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConversationFlowOverrideStartSpeaker?>
    {
        /// <inheritdoc />
        public override global::G.ConversationFlowOverrideStartSpeaker? Read(
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
                        return global::G.ConversationFlowOverrideStartSpeakerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConversationFlowOverrideStartSpeaker)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConversationFlowOverrideStartSpeaker?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConversationFlowOverrideStartSpeaker? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ConversationFlowOverrideStartSpeakerExtensions.ToValueString(value.Value));
            }
        }
    }
}
