//HintName: G.JsonConverters.LlamaParseOutputOptionsImagesToSaveItem.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlamaParseOutputOptionsImagesToSaveItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LlamaParseOutputOptionsImagesToSaveItem>
    {
        /// <inheritdoc />
        public override global::G.LlamaParseOutputOptionsImagesToSaveItem Read(
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
                        return global::G.LlamaParseOutputOptionsImagesToSaveItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.LlamaParseOutputOptionsImagesToSaveItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.LlamaParseOutputOptionsImagesToSaveItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LlamaParseOutputOptionsImagesToSaveItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.LlamaParseOutputOptionsImagesToSaveItemExtensions.ToValueString(value));
        }
    }
}
