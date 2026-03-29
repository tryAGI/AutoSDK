//HintName: G.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type>
    {
        /// <inheritdoc />
        public override global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type Read(
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
                        return global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeExtensions.ToValueString(value));
        }
    }
}
