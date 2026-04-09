//HintName: G.JsonConverters.UpdateSecretExternalLLMRequestDtoVariant2Provider.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateSecretExternalLLMRequestDtoVariant2ProviderJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateSecretExternalLLMRequestDtoVariant2Provider>
    {
        /// <inheritdoc />
        public override global::G.UpdateSecretExternalLLMRequestDtoVariant2Provider ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateSecretExternalLLMRequestDtoVariant2Provider existingValue,
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
                        return global::G.UpdateSecretExternalLLMRequestDtoVariant2ProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateSecretExternalLLMRequestDtoVariant2Provider)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateSecretExternalLLMRequestDtoVariant2Provider);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateSecretExternalLLMRequestDtoVariant2Provider value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateSecretExternalLLMRequestDtoVariant2ProviderExtensions.ToValueString(value));
        }
    }
}
