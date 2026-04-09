//HintName: G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsResponseConnectionDataVariant13AuthSchemeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme>
    {
        /// <inheritdoc />
        public override global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme existingValue,
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
                        return global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthSchemeExtensions.ToValueString(value));
        }
    }
}
