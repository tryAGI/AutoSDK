//HintName: G.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelinesCreatePipelineRequestProducerConfigVariant1TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Type?>
    {
        /// <inheritdoc />
        public override global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Type? Read(
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
                        return global::G.PipelinesCreatePipelineRequestProducerConfigVariant1TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PipelinesCreatePipelineRequestProducerConfigVariant1TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
