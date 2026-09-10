//HintName: G.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormatJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat>
    {
        /// <inheritdoc />
        public override global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat existingValue,
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
                        return global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormatExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormatExtensions.ToValueString(value));
        }
    }
}
