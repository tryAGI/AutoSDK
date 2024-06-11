//HintName: JsonConverters.AssistantsApiResponseFormatOptionVariant1Nullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssistantsApiResponseFormatOptionVariant1NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AssistantsApiResponseFormatOptionVariant1?>
    {
        /// <inheritdoc />
        public override global::G.AssistantsApiResponseFormatOptionVariant1? Read(
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
                        return global::G.AssistantsApiResponseFormatOptionVariant1Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AssistantsApiResponseFormatOptionVariant1)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AssistantsApiResponseFormatOptionVariant1? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.AssistantsApiResponseFormatOptionVariant1Extensions.ToValueString(value.Value));
            }
        }
    }
}
