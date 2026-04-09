//HintName: G.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceIdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId>
    {
        /// <inheritdoc />
        public override global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId existingValue,
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
                        return global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceId value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetAvatarByIdResponseSentimentVariant1VoiceAmazonVoiceIdExtensions.ToValueString(value));
        }
    }
}
