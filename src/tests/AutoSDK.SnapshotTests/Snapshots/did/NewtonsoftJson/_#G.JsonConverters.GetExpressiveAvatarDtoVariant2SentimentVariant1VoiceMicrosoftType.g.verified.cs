//HintName: G.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType>
    {
        /// <inheritdoc />
        public override global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType existingValue,
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
                        return global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceMicrosoftTypeExtensions.ToValueString(value));
        }
    }
}
