//HintName: G.JsonConverters.CreateSecretRequestCreateSecretRequest1ApiKeyType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSecretRequestCreateSecretRequest1ApiKeyTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType>
    {
        /// <inheritdoc />
        public override global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType existingValue,
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
                        return global::G.CreateSecretRequestCreateSecretRequest1ApiKeyTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateSecretRequestCreateSecretRequest1ApiKeyType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateSecretRequestCreateSecretRequest1ApiKeyTypeExtensions.ToValueString(value));
        }
    }
}
