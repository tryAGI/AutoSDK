//HintName: G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status?>
    {
        /// <inheritdoc />
        public override global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status? existingValue,
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
                        return global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
