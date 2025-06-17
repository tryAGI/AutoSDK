//HintName: G.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat?>
    {
        /// <inheritdoc />
        public override global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat? Read(
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
                        return global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
