//HintName: G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces>
    {
        /// <inheritdoc />
        public override global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces existingValue,
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
                        return global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesExtensions.ToValueString(value));
        }
    }
}
