//HintName: recraft.JsonConverters.ResponseFormatNullable.g.cs
#nullable enable

namespace recraft.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::recraft.ResponseFormat?>
    {
        /// <inheritdoc />
        public override global::recraft.ResponseFormat? Read(
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
                        return global::recraft.ResponseFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::recraft.ResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::recraft.ResponseFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::recraft.ResponseFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::recraft.ResponseFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
