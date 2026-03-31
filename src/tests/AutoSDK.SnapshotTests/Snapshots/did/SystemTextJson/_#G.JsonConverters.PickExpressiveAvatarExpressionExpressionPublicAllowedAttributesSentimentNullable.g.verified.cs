//HintName: G.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentimentNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentimentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment?>
    {
        /// <inheritdoc />
        public override global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment? Read(
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
                        return global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentimentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentiment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesSentimentExtensions.ToValueString(value.Value));
            }
        }
    }
}
