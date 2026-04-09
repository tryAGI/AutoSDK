//HintName: G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme?>
    {
        /// <inheritdoc />
        public override global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme? existingValue,
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
                        return global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeExtensions.ToValueString(value.Value));
            }
        }
    }
}
