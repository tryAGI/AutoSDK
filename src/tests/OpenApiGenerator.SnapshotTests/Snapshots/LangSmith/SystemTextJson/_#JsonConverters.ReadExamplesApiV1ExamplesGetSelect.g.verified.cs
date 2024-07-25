//HintName: JsonConverters.ReadExamplesApiV1ExamplesGetSelect.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReadExamplesApiV1ExamplesGetSelectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReadExamplesApiV1ExamplesGetSelect>
    {
        /// <inheritdoc />
        public override global::G.ReadExamplesApiV1ExamplesGetSelect Read(
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
                        return global::G.ReadExamplesApiV1ExamplesGetSelectExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReadExamplesApiV1ExamplesGetSelect)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReadExamplesApiV1ExamplesGetSelect value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReadExamplesApiV1ExamplesGetSelectExtensions.ToValueString(value));
        }
    }
}
