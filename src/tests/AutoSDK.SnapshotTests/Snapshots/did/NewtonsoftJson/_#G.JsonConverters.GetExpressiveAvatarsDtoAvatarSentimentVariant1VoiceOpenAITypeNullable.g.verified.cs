//HintName: G.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAITypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAITypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType?>
    {
        /// <inheritdoc />
        public override global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType? existingValue,
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
                        return global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAITypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAITypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
