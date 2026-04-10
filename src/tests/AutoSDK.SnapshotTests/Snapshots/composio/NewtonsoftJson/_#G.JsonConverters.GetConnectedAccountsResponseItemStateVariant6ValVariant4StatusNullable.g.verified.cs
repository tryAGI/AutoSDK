//HintName: G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status?>
    {
        /// <inheritdoc />
        public override global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status? existingValue,
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
                        return global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
