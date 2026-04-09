//HintName: G.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType>
    {
        /// <inheritdoc />
        public override global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType existingValue,
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
                        return global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeExtensions.ToValueString(value));
        }
    }
}
