//HintName: G.JsonConverters.SearchAllMessagesResponseItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SearchAllMessagesResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SearchAllMessagesResponseItem>
    {
        /// <inheritdoc />
        public override global::G.SearchAllMessagesResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchAllMessagesResponseItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchAllMessagesResponseItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SearchAllMessagesResponseItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SystemMessageListResult? systemMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.SystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemMessageListResult)}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UserMessageListResult? userMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UserMessageListResult)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ReasoningMessageListResult? reasoningMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.ReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ReasoningMessageListResult)}");
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantMessageListResult? assistantMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.AssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantMessageListResult)}");
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.SearchAllMessagesResponseItem(
                discriminator?.MessageType,
                systemMessage,

                userMessage,

                reasoningMessage,

                assistantMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SearchAllMessagesResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeInfo);
            }
            else if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeInfo);
            }
            else if (value.IsReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeInfo);
            }
        }
    }
}