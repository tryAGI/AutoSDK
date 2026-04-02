//HintName: G.JsonConverters.LettaStreamingResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LettaStreamingResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LettaStreamingResponse>
    {
        /// <inheritdoc />
        public override global::G.LettaStreamingResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaStreamingResponseDiscriminator>(ref readerCopy, options);

            global::G.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.SystemMessage)
            {
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SystemMessage>(ref reader, options);
            }
            global::G.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.UserMessage)
            {
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserMessage>(ref reader, options);
            }
            global::G.ReasoningMessage? hiddenReasoningMessage1 = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                hiddenReasoningMessage1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReasoningMessage>(ref reader, options);
            }
            global::G.HiddenReasoningMessage? hiddenReasoningMessage2 = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                hiddenReasoningMessage2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HiddenReasoningMessage>(ref reader, options);
            }
            global::G.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ToolCallMessage)
            {
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolCallMessage>(ref reader, options);
            }
            global::G.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ToolReturnMessage)
            {
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolReturnMessage>(ref reader, options);
            }
            global::G.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.AssistantMessage)
            {
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AssistantMessage>(ref reader, options);
            }
            global::G.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ApprovalRequestMessage)
            {
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApprovalRequestMessage>(ref reader, options);
            }
            global::G.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ApprovalResponseMessage)
            {
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApprovalResponseMessage>(ref reader, options);
            }
            global::G.LettaPing? ping = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.Ping)
            {
                ping = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaPing>(ref reader, options);
            }
            global::G.LettaErrorMessage? errorMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ErrorMessage)
            {
                errorMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaErrorMessage>(ref reader, options);
            }
            global::G.LettaStopReason? stopReason = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.StopReason)
            {
                stopReason = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaStopReason>(ref reader, options);
            }
            global::G.LettaUsageStatistics? usageStatistics = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.UsageStatistics)
            {
                usageStatistics = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LettaUsageStatistics>(ref reader, options);
            }

            var __value = new global::G.LettaStreamingResponse(
                discriminator?.MessageType,
                systemMessage,

                userMessage,

                hiddenReasoningMessage1,

                hiddenReasoningMessage2,

                toolCallMessage,

                toolReturnMessage,

                assistantMessage,

                approvalRequestMessage,

                approvalResponseMessage,

                ping,

                errorMessage,

                stopReason,

                usageStatistics
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LettaStreamingResponse value,
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
            else if (value.IsHiddenReasoningMessage1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage1, typeof(global::G.ReasoningMessage), options);
            }
            else if (value.IsHiddenReasoningMessage2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage2, typeof(global::G.HiddenReasoningMessage), options);
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
            else if (value.IsPing)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping, typeof(global::G.LettaPing), options);
            }
            else if (value.IsErrorMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ErrorMessage, typeof(global::G.LettaErrorMessage), options);
            }
            else if (value.IsStopReason)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StopReason, typeof(global::G.LettaStopReason), options);
            }
            else if (value.IsUsageStatistics)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsageStatistics, typeof(global::G.LettaUsageStatistics), options);
            }
        }
    }
}