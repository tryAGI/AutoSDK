//HintName: G.JsonConverters.ToolConfig.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolConfig>
    {
        /// <inheritdoc />
        public override global::G.ToolConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolRequestModelToolConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolRequestModelToolConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolRequestModelToolConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WebhookToolConfigInput? webhook = default;
            if (discriminator?.Type == global::G.ToolRequestModelToolConfigDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookToolConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebhookToolConfigInput)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClientToolConfigInput? client = default;
            if (discriminator?.Type == global::G.ToolRequestModelToolConfigDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientToolConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientToolConfigInput)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SystemToolConfigInput? system = default;
            if (discriminator?.Type == global::G.ToolRequestModelToolConfigDiscriminatorType.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemToolConfigInput)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MCPToolConfigInput? mcp = default;
            if (discriminator?.Type == global::G.ToolRequestModelToolConfigDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPToolConfigInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MCPToolConfigInput)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ToolConfig(
                discriminator?.Type,
                webhook,

                client,

                system,

                mcp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolConfig value,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemToolConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPToolConfigInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPToolConfigInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPToolConfigInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
        }
    }
}