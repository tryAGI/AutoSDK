//HintName: G.JsonConverters.RealtimeServerEventResponseAudioTranscriptDeltaType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeServerEventResponseAudioTranscriptDeltaTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RealtimeServerEventResponseAudioTranscriptDeltaType>
    {
        /// <inheritdoc />
        public override global::G.RealtimeServerEventResponseAudioTranscriptDeltaType Read(
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
                        return global::G.RealtimeServerEventResponseAudioTranscriptDeltaTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RealtimeServerEventResponseAudioTranscriptDeltaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.RealtimeServerEventResponseAudioTranscriptDeltaType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RealtimeServerEventResponseAudioTranscriptDeltaType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.RealtimeServerEventResponseAudioTranscriptDeltaTypeExtensions.ToValueString(value));
        }
    }
}
