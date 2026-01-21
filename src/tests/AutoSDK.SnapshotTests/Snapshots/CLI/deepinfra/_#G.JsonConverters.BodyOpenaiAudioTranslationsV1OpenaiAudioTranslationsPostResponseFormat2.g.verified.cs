//HintName: G.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2>
    {
        /// <inheritdoc />
        public override global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2 Read(
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
                        return global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2Extensions.ToValueString(value));
        }
    }
}
