//HintName: G.JsonConverters.ToolDetailsVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolDetailsVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolDetailsVariant1>
    {
        /// <inheritdoc />
        public override global::G.ToolDetailsVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator>(ref readerCopy, options);

            global::G.ConversationHistoryTranscriptToolCallWebhookDetails? webhook = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallWebhookDetails>(ref reader, options);
            }
            global::G.ConversationHistoryTranscriptToolCallClientDetails? client = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallClientDetails>(ref reader, options);
            }
            global::G.ConversationHistoryTranscriptToolCallMCPDetails? mcp = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallMCPDetails>(ref reader, options);
            }
            global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook)
            {
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails>(ref reader, options);
            }

            var __value = new global::G.ToolDetailsVariant1(
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
            global::G.ToolDetailsVariant1 value,
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