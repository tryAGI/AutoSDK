//HintName: G.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAITypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType>
    {
        /// <inheritdoc />
        public override global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType existingValue,
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
                        return global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAIType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceOpenAITypeExtensions.ToValueString(value));
        }
    }
}
