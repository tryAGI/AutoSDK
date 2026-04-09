//HintName: G.JsonConverters.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceIdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId>
    {
        /// <inheritdoc />
        public override global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId existingValue,
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
                        return global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceId value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdatePresenterAttributesRequestVariant1VoiceAmazonVoiceIdExtensions.ToValueString(value));
        }
    }
}
