//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType
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