//HintName: G.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType>
    {
        /// <inheritdoc />
        public override global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType Read(
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
                        return global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceAmazonTypeExtensions.ToValueString(value));
        }
    }
}
