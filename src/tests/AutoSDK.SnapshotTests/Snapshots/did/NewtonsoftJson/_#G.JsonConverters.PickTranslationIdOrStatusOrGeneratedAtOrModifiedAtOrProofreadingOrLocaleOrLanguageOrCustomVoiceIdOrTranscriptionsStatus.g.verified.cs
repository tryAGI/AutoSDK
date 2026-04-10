//HintName: G.JsonConverters.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus>
    {
        /// <inheritdoc />
        public override global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus existingValue,
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
                        return global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PickTranslationIdOrStatusOrGeneratedAtOrModifiedAtOrProofreadingOrLocaleOrLanguageOrCustomVoiceIdOrTranscriptionsStatusExtensions.ToValueString(value));
        }
    }
}
