//HintName: G.JsonConverters.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType>
    {
        /// <inheritdoc />
        public override global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType existingValue,
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
                        return global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetAvatars1ResponseAvatarSentimentVariant1VoiceMicrosoftTypeExtensions.ToValueString(value));
        }
    }
}
