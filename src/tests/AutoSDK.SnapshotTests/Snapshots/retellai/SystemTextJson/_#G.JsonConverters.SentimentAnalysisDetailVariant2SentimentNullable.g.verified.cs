//HintName: G.JsonConverters.SentimentAnalysisDetailVariant2SentimentNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SentimentAnalysisDetailVariant2SentimentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SentimentAnalysisDetailVariant2Sentiment?>
    {
        /// <inheritdoc />
        public override global::G.SentimentAnalysisDetailVariant2Sentiment? Read(
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
                        return global::G.SentimentAnalysisDetailVariant2SentimentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SentimentAnalysisDetailVariant2Sentiment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SentimentAnalysisDetailVariant2Sentiment?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SentimentAnalysisDetailVariant2Sentiment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SentimentAnalysisDetailVariant2SentimentExtensions.ToValueString(value.Value));
            }
        }
    }
}
