//HintName: G.JsonConverters.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetResponseVariant1PresenterVideoAvatarVoiceOpenAITypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType>
    {
        /// <inheritdoc />
        public override global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType existingValue,
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
                        return global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAIType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetResponseVariant1PresenterVideoAvatarVoiceOpenAITypeExtensions.ToValueString(value));
        }
    }
}
