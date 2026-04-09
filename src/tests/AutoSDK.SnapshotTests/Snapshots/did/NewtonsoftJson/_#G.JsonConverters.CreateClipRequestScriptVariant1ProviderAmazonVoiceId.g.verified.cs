//HintName: G.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonVoiceId.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateClipRequestScriptVariant1ProviderAmazonVoiceIdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId>
    {
        /// <inheritdoc />
        public override global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId existingValue,
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
                        return global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceIdExtensions.ToValueString(value));
        }
    }
}
