//HintName: G.JsonConverters.FilterStructuredOutputColumnOnCallTableColumnNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilterStructuredOutputColumnOnCallTableColumnNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FilterStructuredOutputColumnOnCallTableColumn?>
    {
        /// <inheritdoc />
        public override global::G.FilterStructuredOutputColumnOnCallTableColumn? Read(
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
                        return global::G.FilterStructuredOutputColumnOnCallTableColumnExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FilterStructuredOutputColumnOnCallTableColumn)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FilterStructuredOutputColumnOnCallTableColumn?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FilterStructuredOutputColumnOnCallTableColumn? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FilterStructuredOutputColumnOnCallTableColumnExtensions.ToValueString(value.Value));
            }
        }
    }
}
