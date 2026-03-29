//HintName: G.Models.ModifyMessageResponseDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModifyMessageResponseDiscriminatorMessageType
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