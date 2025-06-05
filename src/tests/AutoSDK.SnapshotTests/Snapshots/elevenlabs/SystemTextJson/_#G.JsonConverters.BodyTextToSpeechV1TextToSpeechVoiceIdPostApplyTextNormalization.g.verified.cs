//HintName: G.JsonConverters.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization>
    {
        /// <inheritdoc />
        public override global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization Read(
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
                        return global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationExtensions.ToValueString(value));
        }
    }
}
