//HintName: G.JsonConverters.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateClipRequestScriptVariant1ProviderAmazonVoiceId2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2?>
    {
        /// <inheritdoc />
        public override global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2? existingValue,
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
                        return global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateClipRequestScriptVariant1ProviderAmazonVoiceId2Extensions.ToValueString(value.Value));
            }
        }
    }
}
