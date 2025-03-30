//HintName: JsonConverters.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat>
    {
        /// <inheritdoc />
        public override global::G.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat Read(
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
                        return global::G.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormatExtensions.ToValueString(value));
        }
    }
}
