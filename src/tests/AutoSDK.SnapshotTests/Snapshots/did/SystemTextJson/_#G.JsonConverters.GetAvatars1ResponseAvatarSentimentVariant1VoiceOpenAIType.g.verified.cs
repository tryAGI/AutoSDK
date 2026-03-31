//HintName: G.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType>
    {
        /// <inheritdoc />
        public override global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType Read(
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
                        return global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeExtensions.ToValueString(value));
        }
    }
}
