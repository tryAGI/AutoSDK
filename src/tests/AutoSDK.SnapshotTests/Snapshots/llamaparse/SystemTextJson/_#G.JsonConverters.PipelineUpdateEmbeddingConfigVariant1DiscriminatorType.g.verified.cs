//HintName: G.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType Read(
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
                        return global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
