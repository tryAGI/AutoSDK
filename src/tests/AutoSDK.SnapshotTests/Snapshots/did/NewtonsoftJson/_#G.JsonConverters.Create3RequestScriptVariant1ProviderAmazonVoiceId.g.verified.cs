//HintName: G.JsonConverters.Create3RequestScriptVariant1ProviderAmazonVoiceId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Create3RequestScriptVariant1ProviderAmazonVoiceIdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.Create3RequestScriptVariant1ProviderAmazonVoiceId>
    {
        /// <inheritdoc />
        public override global::G.Create3RequestScriptVariant1ProviderAmazonVoiceId ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.Create3RequestScriptVariant1ProviderAmazonVoiceId existingValue,
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
                        return global::G.Create3RequestScriptVariant1ProviderAmazonVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.Create3RequestScriptVariant1ProviderAmazonVoiceId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.Create3RequestScriptVariant1ProviderAmazonVoiceId);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.Create3RequestScriptVariant1ProviderAmazonVoiceId value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.Create3RequestScriptVariant1ProviderAmazonVoiceIdExtensions.ToValueString(value));
        }
    }
}
