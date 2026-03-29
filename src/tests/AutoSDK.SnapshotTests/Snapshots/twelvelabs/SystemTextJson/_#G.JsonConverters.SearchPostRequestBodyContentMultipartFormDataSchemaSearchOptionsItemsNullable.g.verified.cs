//HintName: G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems?>
    {
        /// <inheritdoc />
        public override global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? Read(
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
                        return global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsExtensions.ToValueString(value.Value));
            }
        }
    }
}
