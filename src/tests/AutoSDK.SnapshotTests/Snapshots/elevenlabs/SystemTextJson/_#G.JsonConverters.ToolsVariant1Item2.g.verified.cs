//HintName: G.JsonConverters.ToolsVariant1Item2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolsVariant1Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolsVariant1Item2>
    {
        /// <inheritdoc />
        public override global::G.ToolsVariant1Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WebhookToolConfigOutput? webhook = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebhookToolConfigOutput)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ClientToolConfigOutput? client = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientToolConfigOutput)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SystemToolConfigOutput? system = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemToolConfigOutput)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MCPToolConfigOutput? mcp = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MCPToolConfigOutput)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApiIntegrationWebhookToolConfigOutput? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.ApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApiIntegrationWebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApiIntegrationWebhookToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApiIntegrationWebhookToolConfigOutput)}");
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SMBToolConfig? smb = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Smb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SMBToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SMBToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SMBToolConfig)}");
                smb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ToolsVariant1Item2(
                discriminator?.Type,
                webhook,

                client,

                system,

                mcp,

                apiIntegrationWebhook,

                smb
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolsVariant1Item2 value,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MCPToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MCPToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MCPToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApiIntegrationWebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApiIntegrationWebhookToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApiIntegrationWebhookToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook, typeInfo);
            }
            else if (value.IsSmb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SMBToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SMBToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SMBToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Smb, typeInfo);
            }
        }
    }
}