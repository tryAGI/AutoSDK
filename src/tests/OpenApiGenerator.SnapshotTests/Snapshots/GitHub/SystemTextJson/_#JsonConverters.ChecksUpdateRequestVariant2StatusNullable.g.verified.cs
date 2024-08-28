//HintName: JsonConverters.ChecksUpdateRequestVariant2StatusNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChecksUpdateRequestVariant2StatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChecksUpdateRequestVariant2Status?>
    {
        /// <inheritdoc />
        public override global::G.ChecksUpdateRequestVariant2Status? Read(
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
                        return global::G.ChecksUpdateRequestVariant2StatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChecksUpdateRequestVariant2Status)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChecksUpdateRequestVariant2Status? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ChecksUpdateRequestVariant2StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
