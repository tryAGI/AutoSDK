//HintName: G.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnColumnNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class JSONQueryOnCallTableWithStructuredOutputColumnColumnNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumn?>
    {
        /// <inheritdoc />
        public override global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumn? Read(
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
                        return global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumnExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumn)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumn?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumn? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumnExtensions.ToValueString(value.Value));
            }
        }
    }
}
