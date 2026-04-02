//HintName: G.JsonConverters.ToolsItem2.g.cs
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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PromptAgentAPIModelInputToolDiscriminator>(ref readerCopy, options);

            global::G.WebhookToolConfigInput? webhook = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelInputToolDiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookToolConfigInput>(ref reader, options);
            }
            global::G.ClientToolConfigInput? client = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelInputToolDiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClientToolConfigInput>(ref reader, options);
            }
            global::G.SystemToolConfigInput? system = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelInputToolDiscriminatorType.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemToolConfigInput>(ref reader, options);
            }
            global::G.MCPToolConfigInput? mcp = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelInputToolDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MCPToolConfigInput>(ref reader, options);
            }
            global::G.ApiIntegrationWebhookToolConfigInput? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelInputToolDiscriminatorType.ApiIntegrationWebhook)
            {
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApiIntegrationWebhookToolConfigInput>(ref reader, options);
            }
            global::G.SMBToolConfig? smb = default;
            if (discriminator?.Type == global::G.PromptAgentAPIModelInputToolDiscriminatorType.Smb)
            {
                smb = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SMBToolConfig>(ref reader, options);
            }

            var __value = new global::G.ToolsItem2(
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
            global::G.ToolsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::G.WebhookToolConfigInput), options);
            }
            else if (value.IsClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeof(global::G.ClientToolConfigInput), options);
            }
            else if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::G.SystemToolConfigInput), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::G.MCPToolConfigInput), options);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook, typeof(global::G.ApiIntegrationWebhookToolConfigInput), options);
            }
            else if (value.IsSmb)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Smb, typeof(global::G.SMBToolConfig), options);
            }
        }
    }
}