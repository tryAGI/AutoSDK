//HintName: G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status?>
    {
        /// <inheritdoc />
        public override global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status? existingValue,
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
                        return global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
