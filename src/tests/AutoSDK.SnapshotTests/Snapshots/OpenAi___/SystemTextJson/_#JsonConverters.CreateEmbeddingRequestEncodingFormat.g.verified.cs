//HintName: JsonConverters.CreateEmbeddingRequestEncodingFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateEmbeddingRequestEncodingFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateEmbeddingRequestEncodingFormat>
    {
        /// <inheritdoc />
        public override global::G.CreateEmbeddingRequestEncodingFormat Read(
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
                        return global::G.CreateEmbeddingRequestEncodingFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateEmbeddingRequestEncodingFormat)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateEmbeddingRequestEncodingFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateEmbeddingRequestEncodingFormatExtensions.ToValueString(value));
        }
    }
}
