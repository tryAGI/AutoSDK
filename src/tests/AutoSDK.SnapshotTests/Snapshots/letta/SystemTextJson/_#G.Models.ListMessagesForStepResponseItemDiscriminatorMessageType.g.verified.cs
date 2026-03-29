//HintName: G.Models.ListMessagesForStepResponseItemDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListMessagesForStepResponseItemDiscriminatorMessageType
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
    public static class ListMessagesForStepResponseItemDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMessagesForStepResponseItemDiscriminatorMessageType value)
        {
            return value switch
            {
                ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalRequestMessage => "approval_request_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalResponseMessage => "approval_response_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.AssistantMessage => "assistant_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.EventMessage => "event_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.ReasoningMessage => "reasoning_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.SummaryMessage => "summary_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.SystemMessage => "system_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.ToolCallMessage => "tool_call_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.ToolReturnMessage => "tool_return_message",
                ListMessagesForStepResponseItemDiscriminatorMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMessagesForStepResponseItemDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalRequestMessage,
                "approval_response_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalResponseMessage,
                "assistant_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.AssistantMessage,
                "event_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.EventMessage,
                "hidden_reasoning_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.HiddenReasoningMessage,
                "reasoning_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.ReasoningMessage,
                "summary_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.SummaryMessage,
                "system_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.SystemMessage,
                "tool_call_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.ToolCallMessage,
                "tool_return_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.ToolReturnMessage,
                "user_message" => ListMessagesForStepResponseItemDiscriminatorMessageType.UserMessage,
                _ => null,
            };
        }
    }
}