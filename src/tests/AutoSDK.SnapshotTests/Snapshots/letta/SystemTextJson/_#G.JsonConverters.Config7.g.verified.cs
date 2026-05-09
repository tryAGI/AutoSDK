//HintName: G.JsonConverters.Config7.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Config7JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Config7>
    {
        /// <inheritdoc />
        public override global::G.Config7 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesGetPipelineResponsePipelineConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesGetPipelineResponsePipelineConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PipelinesGetPipelineResponsePipelineConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PipelinesGetPipelineResponsePipelineConfigVariant1? slackChannelReader = default;
            if (discriminator?.Type == "slack_channel_reader")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesGetPipelineResponsePipelineConfigVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant1)}");
                slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PipelinesGetPipelineResponsePipelineConfigVariant2? customWebhook = default;
            if (discriminator?.Type == "custom_webhook")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesGetPipelineResponsePipelineConfigVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant2)}");
                customWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Config7(
                discriminator?.Type,
                slackChannelReader,

                customWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Config7 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesGetPipelineResponsePipelineConfigVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannelReader!, typeInfo);
            }
            else if (value.IsCustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelinesGetPipelineResponsePipelineConfigVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PipelinesGetPipelineResponsePipelineConfigVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomWebhook!, typeInfo);
            }
        }
    }
}