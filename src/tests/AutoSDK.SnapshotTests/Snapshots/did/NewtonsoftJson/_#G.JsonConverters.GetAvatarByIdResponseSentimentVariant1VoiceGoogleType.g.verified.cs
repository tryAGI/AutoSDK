//HintName: G.JsonConverters.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType>
    {
        /// <inheritdoc />
        public override global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType existingValue,
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
                        return global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetAvatarByIdResponseSentimentVariant1VoiceGoogleTypeExtensions.ToValueString(value));
        }
    }
}
