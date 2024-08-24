//HintName: JsonConverters.ControlnetInputInitImageType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ControlnetInputInitImageTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ControlnetInputInitImageType>
    {
        /// <inheritdoc />
        public override global::G.ControlnetInputInitImageType Read(
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
                        return global::G.ControlnetInputInitImageTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ControlnetInputInitImageType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ControlnetInputInitImageType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ControlnetInputInitImageTypeExtensions.ToValueString(value));
        }
    }
}
