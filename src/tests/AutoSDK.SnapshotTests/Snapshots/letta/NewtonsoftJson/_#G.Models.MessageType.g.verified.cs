//HintName: G.Models.MessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approval_request_message")]
        ApprovalRequestMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approval_response_message")]
        ApprovalResponseMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant_message")]
        AssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="event_message")]
        EventMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hidden_reasoning_message")]
        HiddenReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning_message")]
        ReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="summary_message")]
        SummaryMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system_message")]
        SystemMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_call_message")]
        ToolCallMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_return_message")]
        ToolReturnMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_message")]
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