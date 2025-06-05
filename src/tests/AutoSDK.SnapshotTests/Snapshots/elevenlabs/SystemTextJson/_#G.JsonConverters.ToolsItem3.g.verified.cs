//HintName: G.JsonConverters.ToolsItem3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolsItem3>
    {
        /// <inheritdoc />
        public override global::G.ToolsItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAgentOutputToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAgentOutputToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAgentOutputToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WebhookToolConfigOutput? webhook = default;
            if (discriminator?.Type == global::G.PromptAgentOutputToolDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebhookToolConfigOutput)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClientToolConfigOutput? client = default;
            if (discriminator?.Type == global::G.PromptAgentOutputToolDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientToolConfigOutput)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SystemToolConfig? system = default;
            if (discriminator?.Type == global::G.PromptAgentOutputToolDiscriminatorType.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemToolConfig)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolsItem3(
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
            global::G.ToolsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClientToolConfigOutput).Name}");
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