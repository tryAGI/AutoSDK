//HintName: G.JsonConverters.ListMessagesForStepResponseItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ListMessagesForStepResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListMessagesForStepResponseItem>
    {
        /// <inheritdoc />
        public override global::G.ListMessagesForStepResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListMessagesForStepResponseItemDiscriminator>(ref readerCopy, options);

            global::G.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.SystemMessage)
            {
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemMessage>(ref reader, options);
            }
            global::G.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.UserMessage)
            {
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserMessage>(ref reader, options);
            }
            global::G.ReasoningMessage? reasoningMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.ReasoningMessage)
            {
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningMessage>(ref reader, options);
            }
            global::G.HiddenReasoningMessage? hiddenReasoningMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.HiddenReasoningMessage)
            {
                hiddenReasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HiddenReasoningMessage>(ref reader, options);
            }
            global::G.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.ToolCallMessage)
            {
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolCallMessage>(ref reader, options);
            }
            global::G.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.ToolReturnMessage)
            {
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolReturnMessage>(ref reader, options);
            }
            global::G.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.AssistantMessage)
            {
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantMessage>(ref reader, options);
            }
            global::G.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalRequestMessage)
            {
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApprovalRequestMessage>(ref reader, options);
            }
            global::G.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalResponseMessage)
            {
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApprovalResponseMessage>(ref reader, options);
            }
            global::G.SummaryMessage? summaryMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.SummaryMessage)
            {
                summaryMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SummaryMessage>(ref reader, options);
            }
            global::G.EventMessage? eventMessage = default;
            if (discriminator?.MessageType == global::G.ListMessagesForStepResponseItemDiscriminatorMessageType.EventMessage)
            {
                eventMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EventMessage>(ref reader, options);
            }

            var __value = new global::G.ListMessagesForStepResponseItem(
                discriminator?.MessageType,
                systemMessage,

                userMessage,

                reasoningMessage,

                hiddenReasoningMessage,

                toolCallMessage,

                toolReturnMessage,

                assistantMessage,

                approvalRequestMessage,

                approvalResponseMessage,

                summaryMessage,

                eventMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListMessagesForStepResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSystemMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeof(global::G.SystemMessage), options);
            }
            else if (value.IsUserMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeof(global::G.UserMessage), options);
            }
            else if (value.IsReasoningMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage, typeof(global::G.ReasoningMessage), options);
            }
            else if (value.IsHiddenReasoningMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage, typeof(global::G.HiddenReasoningMessage), options);
            }
            else if (value.IsToolCallMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallMessage, typeof(global::G.ToolCallMessage), options);
            }
            else if (value.IsToolReturnMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturnMessage, typeof(global::G.ToolReturnMessage), options);
            }
            else if (value.IsAssistantMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeof(global::G.AssistantMessage), options);
            }
            else if (value.IsApprovalRequestMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalRequestMessage, typeof(global::G.ApprovalRequestMessage), options);
            }
            else if (value.IsApprovalResponseMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalResponseMessage, typeof(global::G.ApprovalResponseMessage), options);
            }
            else if (value.IsSummaryMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryMessage, typeof(global::G.SummaryMessage), options);
            }
            else if (value.IsEventMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EventMessage, typeof(global::G.EventMessage), options);
            }
        }
    }
}