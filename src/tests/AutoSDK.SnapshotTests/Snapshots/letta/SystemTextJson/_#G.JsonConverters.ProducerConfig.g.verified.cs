//HintName: G.JsonConverters.ProducerConfig.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ProducerConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ProducerConfig>
    {
        /// <inheritdoc />
        public override global::G.ProducerConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesCreatePipelineRequestProducerConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesCreatePipelineRequestProducerConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PipelinesCreatePipelineRequestProducerConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PipelinesCreatePipelineRequestProducerConfigVariant1? slackChannelReader = default;
            if (discriminator?.Type == global::G.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType.SlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesCreatePipelineRequestProducerConfigVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant1)}");
                slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PipelinesCreatePipelineRequestProducerConfigVariant2? customWebhook = default;
            if (discriminator?.Type == global::G.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType.CustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesCreatePipelineRequestProducerConfigVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant2)}");
                customWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ProducerConfig(
                discriminator?.Type,
                slackChannelReader,

                customWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ProducerConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesCreatePipelineRequestProducerConfigVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannelReader!, typeInfo);
            }
            else if (value.IsCustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesCreatePipelineRequestProducerConfigVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PipelinesCreatePipelineRequestProducerConfigVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomWebhook!, typeInfo);
            }
        }
    }
}