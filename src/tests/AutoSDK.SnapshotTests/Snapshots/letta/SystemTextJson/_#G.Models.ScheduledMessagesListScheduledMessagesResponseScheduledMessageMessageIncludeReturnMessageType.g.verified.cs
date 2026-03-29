//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        ApprovalRequestMessage,
        /// <summary>
        /// 
        /// </summary>
        ApprovalResponseMessage,
        /// <summary>
        /// 
        /// </summary>
        AssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        HiddenReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        ReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        SystemMessage,
        /// <summary>
        /// 
        /// </summary>
        ToolCallMessage,
        /// <summary>
        /// 
        /// </summary>
        ToolReturnMessage,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType value)
        {
            return value switch
            {
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ApprovalRequestMessage => "approval_request_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ApprovalResponseMessage => "approval_response_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.AssistantMessage => "assistant_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ReasoningMessage => "reasoning_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.SystemMessage => "system_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ToolCallMessage => "tool_call_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ToolReturnMessage => "tool_return_message",
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ApprovalRequestMessage,
                "approval_response_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ApprovalResponseMessage,
                "assistant_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.AssistantMessage,
                "hidden_reasoning_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.HiddenReasoningMessage,
                "reasoning_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ReasoningMessage,
                "system_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.SystemMessage,
                "tool_call_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ToolCallMessage,
                "tool_return_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.ToolReturnMessage,
                "user_message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.UserMessage,
                _ => null,
            };
        }
    }
}