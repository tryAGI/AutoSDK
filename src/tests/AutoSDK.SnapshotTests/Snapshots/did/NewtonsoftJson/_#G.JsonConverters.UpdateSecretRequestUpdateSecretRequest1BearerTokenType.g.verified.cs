//HintName: G.JsonConverters.UpdateSecretRequestUpdateSecretRequest1BearerTokenType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenType>
    {
        /// <inheritdoc />
        public override global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenType existingValue,
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
                        return global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeExtensions.ToValueString(value));
        }
    }
}
