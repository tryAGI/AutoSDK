//HintName: G.Models.ListMessagesForStepResponseItemDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMessagesForStepResponseItemDiscriminatorMessageType
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