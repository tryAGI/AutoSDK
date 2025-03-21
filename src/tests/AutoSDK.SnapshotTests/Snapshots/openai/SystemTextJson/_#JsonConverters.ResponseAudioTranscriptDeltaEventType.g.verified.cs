//HintName: JsonConverters.ResponseAudioTranscriptDeltaEventType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseAudioTranscriptDeltaEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseAudioTranscriptDeltaEventType>
    {
        /// <inheritdoc />
        public override global::G.ResponseAudioTranscriptDeltaEventType Read(
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
                        return global::G.ResponseAudioTranscriptDeltaEventTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ResponseAudioTranscriptDeltaEventType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseAudioTranscriptDeltaEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ResponseAudioTranscriptDeltaEventTypeExtensions.ToValueString(value));
        }
    }
}
