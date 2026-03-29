//HintName: G.Models.ModifyMessageResponseDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModifyMessageResponseDiscriminatorMessageType
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
    public static class ModifyMessageResponseDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyMessageResponseDiscriminatorMessageType value)
        {
            return value switch
            {
                ModifyMessageResponseDiscriminatorMessageType.ApprovalRequestMessage => "approval_request_message",
                ModifyMessageResponseDiscriminatorMessageType.ApprovalResponseMessage => "approval_response_message",
                ModifyMessageResponseDiscriminatorMessageType.AssistantMessage => "assistant_message",
                ModifyMessageResponseDiscriminatorMessageType.EventMessage => "event_message",
                ModifyMessageResponseDiscriminatorMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                ModifyMessageResponseDiscriminatorMessageType.ReasoningMessage => "reasoning_message",
                ModifyMessageResponseDiscriminatorMessageType.SummaryMessage => "summary_message",
                ModifyMessageResponseDiscriminatorMessageType.SystemMessage => "system_message",
                ModifyMessageResponseDiscriminatorMessageType.ToolCallMessage => "tool_call_message",
                ModifyMessageResponseDiscriminatorMessageType.ToolReturnMessage => "tool_return_message",
                ModifyMessageResponseDiscriminatorMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyMessageResponseDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => ModifyMessageResponseDiscriminatorMessageType.ApprovalRequestMessage,
                "approval_response_message" => ModifyMessageResponseDiscriminatorMessageType.ApprovalResponseMessage,
                "assistant_message" => ModifyMessageResponseDiscriminatorMessageType.AssistantMessage,
                "event_message" => ModifyMessageResponseDiscriminatorMessageType.EventMessage,
                "hidden_reasoning_message" => ModifyMessageResponseDiscriminatorMessageType.HiddenReasoningMessage,
                "reasoning_message" => ModifyMessageResponseDiscriminatorMessageType.ReasoningMessage,
                "summary_message" => ModifyMessageResponseDiscriminatorMessageType.SummaryMessage,
                "system_message" => ModifyMessageResponseDiscriminatorMessageType.SystemMessage,
                "tool_call_message" => ModifyMessageResponseDiscriminatorMessageType.ToolCallMessage,
                "tool_return_message" => ModifyMessageResponseDiscriminatorMessageType.ToolReturnMessage,
                "user_message" => ModifyMessageResponseDiscriminatorMessageType.UserMessage,
                _ => null,
            };
        }
    }
}