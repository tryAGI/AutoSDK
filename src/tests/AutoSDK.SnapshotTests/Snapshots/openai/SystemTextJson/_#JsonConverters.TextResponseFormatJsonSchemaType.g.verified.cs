//HintName: JsonConverters.TextResponseFormatJsonSchemaType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextResponseFormatJsonSchemaTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TextResponseFormatJsonSchemaType>
    {
        /// <inheritdoc />
        public override global::G.TextResponseFormatJsonSchemaType Read(
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
                        return global::G.TextResponseFormatJsonSchemaTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TextResponseFormatJsonSchemaType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TextResponseFormatJsonSchemaType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TextResponseFormatJsonSchemaTypeExtensions.ToValueString(value));
        }
    }
}
