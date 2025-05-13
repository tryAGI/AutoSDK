//HintName: JsonConverters.UltravoxV1CallTemplateInitialOutputMediumNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UltravoxV1CallTemplateInitialOutputMediumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UltravoxV1CallTemplateInitialOutputMedium?>
    {
        /// <inheritdoc />
        public override global::G.UltravoxV1CallTemplateInitialOutputMedium? Read(
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
                        return global::G.UltravoxV1CallTemplateInitialOutputMediumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UltravoxV1CallTemplateInitialOutputMedium)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UltravoxV1CallTemplateInitialOutputMedium?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UltravoxV1CallTemplateInitialOutputMedium? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UltravoxV1CallTemplateInitialOutputMediumExtensions.ToValueString(value.Value));
            }
        }
    }
}
