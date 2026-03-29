//HintName: G.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType Read(
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
                        return global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
