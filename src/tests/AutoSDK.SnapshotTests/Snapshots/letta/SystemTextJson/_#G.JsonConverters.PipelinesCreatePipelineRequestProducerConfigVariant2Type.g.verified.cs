//HintName: G.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelinesCreatePipelineRequestProducerConfigVariant2TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PipelinesCreatePipelineRequestProducerConfigVariant2Type>
    {
        /// <inheritdoc />
        public override global::G.PipelinesCreatePipelineRequestProducerConfigVariant2Type Read(
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
                        return global::G.PipelinesCreatePipelineRequestProducerConfigVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PipelinesCreatePipelineRequestProducerConfigVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PipelinesCreatePipelineRequestProducerConfigVariant2Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PipelinesCreatePipelineRequestProducerConfigVariant2Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PipelinesCreatePipelineRequestProducerConfigVariant2TypeExtensions.ToValueString(value));
        }
    }
}
