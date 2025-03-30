//HintName: JsonConverters.QueryExampleSchemaWithRunsFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueryExampleSchemaWithRunsFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.QueryExampleSchemaWithRunsFormat?>
    {
        /// <inheritdoc />
        public override global::G.QueryExampleSchemaWithRunsFormat? Read(
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
                        return global::G.QueryExampleSchemaWithRunsFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.QueryExampleSchemaWithRunsFormat)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.QueryExampleSchemaWithRunsFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.QueryExampleSchemaWithRunsFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
