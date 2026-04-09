//HintName: G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type>
    {
        /// <inheritdoc />
        public override global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type existingValue,
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
                        return global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeExtensions.ToValueString(value));
        }
    }
}
