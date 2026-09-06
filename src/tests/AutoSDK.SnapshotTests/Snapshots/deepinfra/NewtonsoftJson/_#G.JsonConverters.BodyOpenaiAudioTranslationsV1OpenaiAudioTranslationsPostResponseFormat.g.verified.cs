//HintName: G.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat>
    {
        /// <inheritdoc />
        public override global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatExtensions.ToValueString(value));
        }
    }
}
