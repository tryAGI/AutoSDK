//HintName: G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status?>
    {
        /// <inheritdoc />
        public override global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
