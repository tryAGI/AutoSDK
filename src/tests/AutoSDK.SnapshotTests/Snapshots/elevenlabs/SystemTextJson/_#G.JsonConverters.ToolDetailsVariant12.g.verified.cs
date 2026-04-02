//HintName: G.JsonConverters.ToolDetailsVariant12.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolDetailsVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolDetailsVariant12>
    {
        /// <inheritdoc />
        public override global::G.ToolDetailsVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1Discriminator>(ref readerCopy, options);

            global::G.ConversationHistoryTranscriptToolCallWebhookDetails? webhook = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallWebhookDetails>(ref reader, options);
            }
            global::G.ConversationHistoryTranscriptToolCallClientDetails? client = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallClientDetails>(ref reader, options);
            }
            global::G.ConversationHistoryTranscriptToolCallMCPDetails? mcp = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallMCPDetails>(ref reader, options);
            }
            global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook)
            {
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails>(ref reader, options);
            }

            var __value = new global::G.ToolDetailsVariant12(
                discriminator?.Type,
                webhook,

                client,

                mcp,

                apiIntegrationWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolDetailsVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::G.ConversationHistoryTranscriptToolCallWebhookDetails), options);
            }
            else if (value.IsClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeof(global::G.ConversationHistoryTranscriptToolCallClientDetails), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::G.ConversationHistoryTranscriptToolCallMCPDetails), options);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook, typeof(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails), options);
            }
        }
    }
}