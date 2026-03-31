//HintName: G.JsonConverters.GetTalksDtoTalkConfigDriverExpressionsExpressionExpressionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTalksDtoTalkConfigDriverExpressionsExpressionExpressionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression?>
    {
        /// <inheritdoc />
        public override global::G.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression? Read(
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
                        return global::G.GetTalksDtoTalkConfigDriverExpressionsExpressionExpressionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetTalksDtoTalkConfigDriverExpressionsExpressionExpressionExtensions.ToValueString(value.Value));
            }
        }
    }
}
