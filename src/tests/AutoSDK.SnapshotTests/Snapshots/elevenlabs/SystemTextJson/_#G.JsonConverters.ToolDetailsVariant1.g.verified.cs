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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ConversationHistoryTranscriptToolCallWebhookDetails? webhook = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallWebhookDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryTranscriptToolCallWebhookDetails)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationHistoryTranscriptToolCallClientDetails? client = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallClientDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallClientDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryTranscriptToolCallClientDetails)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationHistoryTranscriptToolCallMCPDetails? mcp = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallMCPDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallMCPDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryTranscriptToolCallMCPDetails)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::G.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails)}");
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallWebhookDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationHistoryTranscriptToolCallWebhookDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallClientDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallClientDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationHistoryTranscriptToolCallClientDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallMCPDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallMCPDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationHistoryTranscriptToolCallMCPDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook!, typeInfo);
            }
        }
    }
}