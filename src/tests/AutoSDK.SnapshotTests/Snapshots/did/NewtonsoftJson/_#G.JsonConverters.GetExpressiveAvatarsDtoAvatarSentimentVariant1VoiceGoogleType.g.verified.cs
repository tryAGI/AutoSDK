//HintName: G.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType>
    {
        /// <inheritdoc />
        public override global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType existingValue,
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
                        return global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleTypeExtensions.ToValueString(value));
        }
    }
}
