//HintName: G.JsonConverters.ElevenLabsTextToSpeechOptionsVoice.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ElevenLabsTextToSpeechOptionsVoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ElevenLabsTextToSpeechOptionsVoice>
    {
        /// <inheritdoc />
        public override global::G.ElevenLabsTextToSpeechOptionsVoice Read(
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
                        return global::G.ElevenLabsTextToSpeechOptionsVoiceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ElevenLabsTextToSpeechOptionsVoice)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ElevenLabsTextToSpeechOptionsVoice);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ElevenLabsTextToSpeechOptionsVoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ElevenLabsTextToSpeechOptionsVoiceExtensions.ToValueString(value));
        }
    }
}
