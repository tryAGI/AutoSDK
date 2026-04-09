//HintName: G.JsonConverters.HashicorpTokenAuthConfigVaultAuthType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HashicorpTokenAuthConfigVaultAuthTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.HashicorpTokenAuthConfigVaultAuthType>
    {
        /// <inheritdoc />
        public override global::G.HashicorpTokenAuthConfigVaultAuthType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.HashicorpTokenAuthConfigVaultAuthType existingValue,
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
                        return global::G.HashicorpTokenAuthConfigVaultAuthTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.HashicorpTokenAuthConfigVaultAuthType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.HashicorpTokenAuthConfigVaultAuthType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.HashicorpTokenAuthConfigVaultAuthType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.HashicorpTokenAuthConfigVaultAuthTypeExtensions.ToValueString(value));
        }
    }
}
