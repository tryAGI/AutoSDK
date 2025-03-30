//HintName: JsonConverters.ToolsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolsItem2>
    {
        /// <inheritdoc />
        public override global::G.ToolsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAgentInputToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAgentInputToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAgentInputToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WebhookToolConfigInput? webhook = default;
            if (discriminator?.Type == global::G.PromptAgentInputToolDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookToolConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebhookToolConfigInput)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClientToolConfigInput? client = default;
            if (discriminator?.Type == global::G.PromptAgentInputToolDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientToolConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientToolConfigInput)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SystemToolConfig? system = default;
            if (discriminator?.Type == global::G.PromptAgentInputToolDiscriminatorType.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemToolConfig)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolsItem2(
                discriminator?.Type,
                webhook,
                client,
                system
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookToolConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookToolConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientToolConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClientToolConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
        }
    }
}