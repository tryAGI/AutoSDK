//HintName: G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsResponseConnectionDataVariant13ValVariant2StatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status>
    {
        /// <inheritdoc />
        public override global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status Read(
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
                        return global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2StatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2StatusExtensions.ToValueString(value));
        }
    }
}
