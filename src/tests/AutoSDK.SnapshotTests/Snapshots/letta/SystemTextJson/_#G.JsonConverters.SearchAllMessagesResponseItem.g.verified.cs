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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SearchAllMessagesResponseItemDiscriminator>(ref readerCopy, options);

            global::G.SystemMessageListResult? systemMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.SystemMessage)
            {
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemMessageListResult>(ref reader, options);
            }
            global::G.UserMessageListResult? userMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.UserMessage)
            {
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserMessageListResult>(ref reader, options);
            }
            global::G.ReasoningMessageListResult? reasoningMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.ReasoningMessage)
            {
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningMessageListResult>(ref reader, options);
            }
            global::G.AssistantMessageListResult? assistantMessage = default;
            if (discriminator?.MessageType == global::G.SearchAllMessagesResponseItemDiscriminatorMessageType.AssistantMessage)
            {
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantMessageListResult>(ref reader, options);
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

            if (value.IsSystemMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeof(global::G.SystemMessageListResult), options);
            }
            else if (value.IsUserMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeof(global::G.UserMessageListResult), options);
            }
            else if (value.IsReasoningMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage, typeof(global::G.ReasoningMessageListResult), options);
            }
            else if (value.IsAssistantMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeof(global::G.AssistantMessageListResult), options);
            }
        }
    }
}