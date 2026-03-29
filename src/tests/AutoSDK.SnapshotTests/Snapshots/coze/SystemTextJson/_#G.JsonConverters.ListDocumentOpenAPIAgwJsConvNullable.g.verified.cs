//HintName: G.JsonConverters.ListDocumentOpenAPIAgwJsConvNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListDocumentOpenAPIAgwJsConvNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListDocumentOpenAPIAgwJsConv?>
    {
        /// <inheritdoc />
        public override global::G.ListDocumentOpenAPIAgwJsConv? Read(
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
                        return global::G.ListDocumentOpenAPIAgwJsConvExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListDocumentOpenAPIAgwJsConv)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListDocumentOpenAPIAgwJsConv?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListDocumentOpenAPIAgwJsConv? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ListDocumentOpenAPIAgwJsConvExtensions.ToValueString(value.Value));
            }
        }
    }
}
