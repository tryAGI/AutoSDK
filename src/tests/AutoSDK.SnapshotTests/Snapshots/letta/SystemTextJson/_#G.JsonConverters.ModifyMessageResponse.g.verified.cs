//HintName: G.JsonConverters.ModifyMessageResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ModifyMessageResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModifyMessageResponse>
    {
        /// <inheritdoc />
        public override global::G.ModifyMessageResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModifyMessageResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModifyMessageResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ModifyMessageResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.SystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemMessage)}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UserMessage)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ReasoningMessage? reasoningMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.ReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ReasoningMessage)}");
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HiddenReasoningMessage? hiddenReasoningMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HiddenReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HiddenReasoningMessage)}");
                hiddenReasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.ToolCallMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolCallMessage)}");
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.ToolReturnMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolReturnMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolReturnMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolReturnMessage)}");
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.AssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantMessage)}");
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.ApprovalRequestMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalRequestMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalRequestMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApprovalRequestMessage)}");
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.ApprovalResponseMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApprovalResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApprovalResponseMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApprovalResponseMessage)}");
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SummaryMessage? summaryMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.SummaryMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SummaryMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SummaryMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SummaryMessage)}");
                summaryMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.EventMessage? eventMessage = default;
            if (discriminator?.MessageType == global::G.ModifyMessageResponseDiscriminatorMessageType.EventMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EventMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EventMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EventMessage)}");
                eventMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ModifyMessageResponse(
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
            global::G.ModifyMessageResponse value,
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
            else if (value.IsReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage, typeInfo);
            }
            else if (value.IsHiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HiddenReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HiddenReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage, typeInfo);
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
            else if (value.IsSummaryMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SummaryMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SummaryMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SummaryMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryMessage, typeInfo);
            }
            else if (value.IsEventMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EventMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EventMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EventMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EventMessage, typeInfo);
            }
        }
    }
}