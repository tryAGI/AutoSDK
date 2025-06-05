//HintName: recraft.JsonConverters.TransformModelNullable.g.cs
#nullable enable

namespace recraft.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransformModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::recraft.TransformModel?>
    {
        /// <inheritdoc />
        public override global::recraft.TransformModel? Read(
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
                        return global::recraft.TransformModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::recraft.TransformModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::recraft.TransformModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::recraft.TransformModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::recraft.TransformModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
