//HintName: G.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlamaParseParametersImagesToSaveVariant1ItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LlamaParseParametersImagesToSaveVariant1Item?>
    {
        /// <inheritdoc />
        public override global::G.LlamaParseParametersImagesToSaveVariant1Item? Read(
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
                        return global::G.LlamaParseParametersImagesToSaveVariant1ItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.LlamaParseParametersImagesToSaveVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.LlamaParseParametersImagesToSaveVariant1Item?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LlamaParseParametersImagesToSaveVariant1Item? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.LlamaParseParametersImagesToSaveVariant1ItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
