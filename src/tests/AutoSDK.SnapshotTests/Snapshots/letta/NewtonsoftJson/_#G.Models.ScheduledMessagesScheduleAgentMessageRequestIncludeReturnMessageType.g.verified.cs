//HintName: G.Models.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType
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
    public static class ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType value)
        {
            return value switch
            {
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ApprovalRequestMessage => "approval_request_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ApprovalResponseMessage => "approval_response_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.AssistantMessage => "assistant_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ReasoningMessage => "reasoning_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.SystemMessage => "system_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ToolCallMessage => "tool_call_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ToolReturnMessage => "tool_return_message",
                ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ApprovalRequestMessage,
                "approval_response_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ApprovalResponseMessage,
                "assistant_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.AssistantMessage,
                "hidden_reasoning_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.HiddenReasoningMessage,
                "reasoning_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ReasoningMessage,
                "system_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.SystemMessage,
                "tool_call_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ToolCallMessage,
                "tool_return_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.ToolReturnMessage,
                "user_message" => ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType.UserMessage,
                _ => null,
            };
        }
    }
}