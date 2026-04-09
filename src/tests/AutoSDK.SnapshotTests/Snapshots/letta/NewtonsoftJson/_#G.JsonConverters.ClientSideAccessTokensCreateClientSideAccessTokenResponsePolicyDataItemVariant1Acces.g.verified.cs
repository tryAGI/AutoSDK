//HintName: G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces>
    {
        /// <inheritdoc />
        public override global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces existingValue,
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
                        return global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesExtensions.ToValueString(value));
        }
    }
}
