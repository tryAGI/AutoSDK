//HintName: G.JsonConverters.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceIdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceIdNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId?>
    {
        /// <inheritdoc />
        public override global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId? existingValue,
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
                        return global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceIdExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceId? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1VoiceAmazonVoiceIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
