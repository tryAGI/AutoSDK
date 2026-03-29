//HintName: G.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateResearchRequestOutputSchemaPropertiesTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateResearchRequestOutputSchemaPropertiesType?>
    {
        /// <inheritdoc />
        public override global::G.CreateResearchRequestOutputSchemaPropertiesType? Read(
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
                        return global::G.CreateResearchRequestOutputSchemaPropertiesTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateResearchRequestOutputSchemaPropertiesType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateResearchRequestOutputSchemaPropertiesType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateResearchRequestOutputSchemaPropertiesType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateResearchRequestOutputSchemaPropertiesTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
