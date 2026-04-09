//HintName: G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsResponseItemStateVariant1ValVariant6StatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status>
    {
        /// <inheritdoc />
        public override global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status existingValue,
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
                        return global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6StatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6StatusExtensions.ToValueString(value));
        }
    }
}
