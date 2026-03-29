//HintName: G.Models.ModifyGroupMessageResponseDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModifyGroupMessageResponseDiscriminatorMessageType
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
    public static class ModifyGroupMessageResponseDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyGroupMessageResponseDiscriminatorMessageType value)
        {
            return value switch
            {
                ModifyGroupMessageResponseDiscriminatorMessageType.ApprovalRequestMessage => "approval_request_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.ApprovalResponseMessage => "approval_response_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.AssistantMessage => "assistant_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.EventMessage => "event_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.ReasoningMessage => "reasoning_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.SummaryMessage => "summary_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.SystemMessage => "system_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.ToolCallMessage => "tool_call_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.ToolReturnMessage => "tool_return_message",
                ModifyGroupMessageResponseDiscriminatorMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyGroupMessageResponseDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => ModifyGroupMessageResponseDiscriminatorMessageType.ApprovalRequestMessage,
                "approval_response_message" => ModifyGroupMessageResponseDiscriminatorMessageType.ApprovalResponseMessage,
                "assistant_message" => ModifyGroupMessageResponseDiscriminatorMessageType.AssistantMessage,
                "event_message" => ModifyGroupMessageResponseDiscriminatorMessageType.EventMessage,
                "hidden_reasoning_message" => ModifyGroupMessageResponseDiscriminatorMessageType.HiddenReasoningMessage,
                "reasoning_message" => ModifyGroupMessageResponseDiscriminatorMessageType.ReasoningMessage,
                "summary_message" => ModifyGroupMessageResponseDiscriminatorMessageType.SummaryMessage,
                "system_message" => ModifyGroupMessageResponseDiscriminatorMessageType.SystemMessage,
                "tool_call_message" => ModifyGroupMessageResponseDiscriminatorMessageType.ToolCallMessage,
                "tool_return_message" => ModifyGroupMessageResponseDiscriminatorMessageType.ToolReturnMessage,
                "user_message" => ModifyGroupMessageResponseDiscriminatorMessageType.UserMessage,
                _ => null,
            };
        }
    }
}