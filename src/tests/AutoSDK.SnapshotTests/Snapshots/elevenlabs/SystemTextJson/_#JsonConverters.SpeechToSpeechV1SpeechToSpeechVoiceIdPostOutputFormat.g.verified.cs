//HintName: JsonConverters.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat>
    {
        /// <inheritdoc />
        public override global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat Read(
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
                        return global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatExtensions.ToValueString(value));
        }
    }
}
