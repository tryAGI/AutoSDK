//HintName: G.Models.LettaMessageUnionDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaMessageUnionDiscriminatorMessageType
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
    public static class LettaMessageUnionDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaMessageUnionDiscriminatorMessageType value)
        {
            return value switch
            {
                LettaMessageUnionDiscriminatorMessageType.ApprovalRequestMessage => "approval_request_message",
                LettaMessageUnionDiscriminatorMessageType.ApprovalResponseMessage => "approval_response_message",
                LettaMessageUnionDiscriminatorMessageType.AssistantMessage => "assistant_message",
                LettaMessageUnionDiscriminatorMessageType.EventMessage => "event_message",
                LettaMessageUnionDiscriminatorMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                LettaMessageUnionDiscriminatorMessageType.ReasoningMessage => "reasoning_message",
                LettaMessageUnionDiscriminatorMessageType.SummaryMessage => "summary_message",
                LettaMessageUnionDiscriminatorMessageType.SystemMessage => "system_message",
                LettaMessageUnionDiscriminatorMessageType.ToolCallMessage => "tool_call_message",
                LettaMessageUnionDiscriminatorMessageType.ToolReturnMessage => "tool_return_message",
                LettaMessageUnionDiscriminatorMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaMessageUnionDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => LettaMessageUnionDiscriminatorMessageType.ApprovalRequestMessage,
                "approval_response_message" => LettaMessageUnionDiscriminatorMessageType.ApprovalResponseMessage,
                "assistant_message" => LettaMessageUnionDiscriminatorMessageType.AssistantMessage,
                "event_message" => LettaMessageUnionDiscriminatorMessageType.EventMessage,
                "hidden_reasoning_message" => LettaMessageUnionDiscriminatorMessageType.HiddenReasoningMessage,
                "reasoning_message" => LettaMessageUnionDiscriminatorMessageType.ReasoningMessage,
                "summary_message" => LettaMessageUnionDiscriminatorMessageType.SummaryMessage,
                "system_message" => LettaMessageUnionDiscriminatorMessageType.SystemMessage,
                "tool_call_message" => LettaMessageUnionDiscriminatorMessageType.ToolCallMessage,
                "tool_return_message" => LettaMessageUnionDiscriminatorMessageType.ToolReturnMessage,
                "user_message" => LettaMessageUnionDiscriminatorMessageType.UserMessage,
                _ => null,
            };
        }
    }
}