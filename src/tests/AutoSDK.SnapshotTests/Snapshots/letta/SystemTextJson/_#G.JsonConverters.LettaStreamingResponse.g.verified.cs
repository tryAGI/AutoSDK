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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaStreamingResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaStreamingResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaStreamingResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.SystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemMessage)}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UserMessage)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ReasoningMessage? hiddenReasoningMessage1 = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ReasoningMessage)}");
                hiddenReasoningMessage1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HiddenReasoningMessage? hiddenReasoningMessage2 = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HiddenReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HiddenReasoningMessage)}");
                hiddenReasoningMessage2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ToolCallMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolCallMessage)}");
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ToolReturnMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolReturnMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolReturnMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolReturnMessage)}");
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.AssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantMessage)}");
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ApprovalRequestMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalRequestMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalRequestMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApprovalRequestMessage)}");
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ApprovalResponseMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalResponseMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApprovalResponseMessage)}");
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaPing? ping = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.Ping)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaPing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaPing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaPing)}");
                ping = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaErrorMessage? errorMessage = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.ErrorMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaErrorMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaErrorMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaErrorMessage)}");
                errorMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaStopReason? stopReason = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.StopReason)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaStopReason), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaStopReason> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaStopReason)}");
                stopReason = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaUsageStatistics? usageStatistics = default;
            if (discriminator?.MessageType == global::G.LettaStreamingResponseDiscriminatorMessageType.UsageStatistics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaUsageStatistics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaUsageStatistics> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaUsageStatistics)}");
                usageStatistics = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeInfo);
            }
            else if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeInfo);
            }
            else if (value.IsHiddenReasoningMessage1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage1, typeInfo);
            }
            else if (value.IsHiddenReasoningMessage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HiddenReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HiddenReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage2, typeInfo);
            }
            else if (value.IsToolCallMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallMessage, typeInfo);
            }
            else if (value.IsToolReturnMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolReturnMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolReturnMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolReturnMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturnMessage, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeInfo);
            }
            else if (value.IsApprovalRequestMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalRequestMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalRequestMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApprovalRequestMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalRequestMessage, typeInfo);
            }
            else if (value.IsApprovalResponseMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalResponseMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApprovalResponseMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalResponseMessage, typeInfo);
            }
            else if (value.IsPing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaPing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaPing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaPing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping, typeInfo);
            }
            else if (value.IsErrorMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaErrorMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaErrorMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaErrorMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ErrorMessage, typeInfo);
            }
            else if (value.IsStopReason)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaStopReason), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaStopReason?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaStopReason).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StopReason, typeInfo);
            }
            else if (value.IsUsageStatistics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaUsageStatistics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaUsageStatistics?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaUsageStatistics).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsageStatistics, typeInfo);
            }
        }
    }
}