//HintName: G.JsonConverters.ImageToImageRequestBodyDiscriminatorInitImageModeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageToImageRequestBodyDiscriminatorInitImageModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ImageToImageRequestBodyDiscriminatorInitImageMode?>
    {
        /// <inheritdoc />
        public override global::G.ImageToImageRequestBodyDiscriminatorInitImageMode? Read(
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
                        return global::G.ImageToImageRequestBodyDiscriminatorInitImageModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ImageToImageRequestBodyDiscriminatorInitImageMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ImageToImageRequestBodyDiscriminatorInitImageMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ImageToImageRequestBodyDiscriminatorInitImageMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ImageToImageRequestBodyDiscriminatorInitImageModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
