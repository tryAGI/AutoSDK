//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType
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