//HintName: G.Models.LettaStreamingResponseDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaStreamingResponseDiscriminatorMessageType
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
        [global::System.Runtime.Serialization.EnumMember(Value="error_message")]
        ErrorMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hidden_reasoning_message")]
        HiddenReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ping")]
        Ping,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning_message")]
        ReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop_reason")]
        StopReason,
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
        [global::System.Runtime.Serialization.EnumMember(Value="usage_statistics")]
        UsageStatistics,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_message")]
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LettaStreamingResponseDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaStreamingResponseDiscriminatorMessageType value)
        {
            return value switch
            {
                LettaStreamingResponseDiscriminatorMessageType.ApprovalRequestMessage => "approval_request_message",
                LettaStreamingResponseDiscriminatorMessageType.ApprovalResponseMessage => "approval_response_message",
                LettaStreamingResponseDiscriminatorMessageType.AssistantMessage => "assistant_message",
                LettaStreamingResponseDiscriminatorMessageType.ErrorMessage => "error_message",
                LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage => "hidden_reasoning_message",
                LettaStreamingResponseDiscriminatorMessageType.Ping => "ping",
                LettaStreamingResponseDiscriminatorMessageType.ReasoningMessage => "reasoning_message",
                LettaStreamingResponseDiscriminatorMessageType.StopReason => "stop_reason",
                LettaStreamingResponseDiscriminatorMessageType.SystemMessage => "system_message",
                LettaStreamingResponseDiscriminatorMessageType.ToolCallMessage => "tool_call_message",
                LettaStreamingResponseDiscriminatorMessageType.ToolReturnMessage => "tool_return_message",
                LettaStreamingResponseDiscriminatorMessageType.UsageStatistics => "usage_statistics",
                LettaStreamingResponseDiscriminatorMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaStreamingResponseDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "approval_request_message" => LettaStreamingResponseDiscriminatorMessageType.ApprovalRequestMessage,
                "approval_response_message" => LettaStreamingResponseDiscriminatorMessageType.ApprovalResponseMessage,
                "assistant_message" => LettaStreamingResponseDiscriminatorMessageType.AssistantMessage,
                "error_message" => LettaStreamingResponseDiscriminatorMessageType.ErrorMessage,
                "hidden_reasoning_message" => LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage,
                "ping" => LettaStreamingResponseDiscriminatorMessageType.Ping,
                "reasoning_message" => LettaStreamingResponseDiscriminatorMessageType.ReasoningMessage,
                "stop_reason" => LettaStreamingResponseDiscriminatorMessageType.StopReason,
                "system_message" => LettaStreamingResponseDiscriminatorMessageType.SystemMessage,
                "tool_call_message" => LettaStreamingResponseDiscriminatorMessageType.ToolCallMessage,
                "tool_return_message" => LettaStreamingResponseDiscriminatorMessageType.ToolReturnMessage,
                "usage_statistics" => LettaStreamingResponseDiscriminatorMessageType.UsageStatistics,
                "user_message" => LettaStreamingResponseDiscriminatorMessageType.UserMessage,
                _ => null,
            };
        }
    }
}