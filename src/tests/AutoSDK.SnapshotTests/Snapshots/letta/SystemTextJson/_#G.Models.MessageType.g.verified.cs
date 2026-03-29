//HintName: G.Models.MessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageType
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
        EventMessage,
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
        SummaryMessage,
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
    public static class MessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageType value)
        {
            return value switch
            {
                MessageType.ApprovalRequestMessage => "approval_request_message",
                MessageType.ApprovalResponseMessage => "approval_response_message",
                MessageType.AssistantMessage => "assistant_message",
                MessageType.EventMessage => "event_message",
                MessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                MessageType.ReasoningMessage => "reasoning_message",
                MessageType.SummaryMessage => "summary_message",
                MessageType.SystemMessage => "system_message",
                MessageType.ToolCallMessage => "tool_call_message",
                MessageType.ToolReturnMessage => "tool_return_message",
                MessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => MessageType.ApprovalRequestMessage,
                "approval_response_message" => MessageType.ApprovalResponseMessage,
                "assistant_message" => MessageType.AssistantMessage,
                "event_message" => MessageType.EventMessage,
                "hidden_reasoning_message" => MessageType.HiddenReasoningMessage,
                "reasoning_message" => MessageType.ReasoningMessage,
                "summary_message" => MessageType.SummaryMessage,
                "system_message" => MessageType.SystemMessage,
                "tool_call_message" => MessageType.ToolCallMessage,
                "tool_return_message" => MessageType.ToolReturnMessage,
                "user_message" => MessageType.UserMessage,
                _ => null,
            };
        }
    }
}