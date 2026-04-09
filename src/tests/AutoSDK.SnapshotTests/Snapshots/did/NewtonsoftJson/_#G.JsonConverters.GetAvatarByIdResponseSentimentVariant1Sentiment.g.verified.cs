//HintName: G.JsonConverters.GetAvatarByIdResponseSentimentVariant1Sentiment.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarByIdResponseSentimentVariant1SentimentJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetAvatarByIdResponseSentimentVariant1Sentiment>
    {
        /// <inheritdoc />
        public override global::G.GetAvatarByIdResponseSentimentVariant1Sentiment ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetAvatarByIdResponseSentimentVariant1Sentiment existingValue,
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
                        return global::G.GetAvatarByIdResponseSentimentVariant1SentimentExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetAvatarByIdResponseSentimentVariant1Sentiment)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetAvatarByIdResponseSentimentVariant1Sentiment);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetAvatarByIdResponseSentimentVariant1Sentiment value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetAvatarByIdResponseSentimentVariant1SentimentExtensions.ToValueString(value));
        }
    }
}
