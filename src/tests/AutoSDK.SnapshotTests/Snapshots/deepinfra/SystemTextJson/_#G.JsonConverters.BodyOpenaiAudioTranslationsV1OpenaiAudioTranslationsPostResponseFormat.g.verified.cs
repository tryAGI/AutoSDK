//HintName: G.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat>
    {
        /// <inheritdoc />
        public override global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat Read(
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
                        return global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatExtensions.ToValueString(value));
        }
    }
}
