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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptAgentAPIModelOutputToolDiscriminator>(ref readerCopy, options);

            global::G.WebhookToolConfigOutput? webhook = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelOutputToolDiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookToolConfigOutput>(ref reader, options);
            }
            global::G.ClientToolConfigOutput? client = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelOutputToolDiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClientToolConfigOutput>(ref reader, options);
            }
            global::G.SystemToolConfigOutput? system = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelOutputToolDiscriminatorType.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemToolConfigOutput>(ref reader, options);
            }
            global::G.MCPToolConfigOutput? mcp = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelOutputToolDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPToolConfigOutput>(ref reader, options);
            }
            global::G.ApiIntegrationWebhookToolConfigOutput? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelOutputToolDiscriminatorType.ApiIntegrationWebhook)
            {
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApiIntegrationWebhookToolConfigOutput>(ref reader, options);
            }
            global::G.SMBToolConfig? smb = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelOutputToolDiscriminatorType.Smb)
            {
                smb = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SMBToolConfig>(ref reader, options);
            }

            var __value = new global::G.ToolsItem3(
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
            global::G.ToolsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::G.WebhookToolConfigOutput), options);
            }
            else if (value.IsClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeof(global::G.ClientToolConfigOutput), options);
            }
            else if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::G.SystemToolConfigOutput), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::G.MCPToolConfigOutput), options);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook, typeof(global::G.ApiIntegrationWebhookToolConfigOutput), options);
            }
            else if (value.IsSmb)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Smb, typeof(global::G.SMBToolConfig), options);
            }
        }
    }
}