//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType
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
    public static class ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType value)
        {
            return value switch
            {
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ApprovalRequestMessage => "approval_request_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ApprovalResponseMessage => "approval_response_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.AssistantMessage => "assistant_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ReasoningMessage => "reasoning_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.SystemMessage => "system_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ToolCallMessage => "tool_call_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ToolReturnMessage => "tool_return_message",
                ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ApprovalRequestMessage,
                "approval_response_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ApprovalResponseMessage,
                "assistant_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.AssistantMessage,
                "hidden_reasoning_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.HiddenReasoningMessage,
                "reasoning_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ReasoningMessage,
                "system_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.SystemMessage,
                "tool_call_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ToolCallMessage,
                "tool_return_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.ToolReturnMessage,
                "user_message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.UserMessage,
                _ => null,
            };
        }
    }
}