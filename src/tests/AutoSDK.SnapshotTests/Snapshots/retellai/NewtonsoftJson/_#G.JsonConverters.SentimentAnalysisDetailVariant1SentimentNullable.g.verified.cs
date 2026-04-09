//HintName: G.JsonConverters.SentimentAnalysisDetailVariant1SentimentNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SentimentAnalysisDetailVariant1SentimentNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.SentimentAnalysisDetailVariant1Sentiment?>
    {
        /// <inheritdoc />
        public override global::G.SentimentAnalysisDetailVariant1Sentiment? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.SentimentAnalysisDetailVariant1Sentiment? existingValue,
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
                        return global::G.SentimentAnalysisDetailVariant1SentimentExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.SentimentAnalysisDetailVariant1Sentiment)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.SentimentAnalysisDetailVariant1Sentiment?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.SentimentAnalysisDetailVariant1Sentiment? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.SentimentAnalysisDetailVariant1SentimentExtensions.ToValueString(value.Value));
            }
        }
    }
}
