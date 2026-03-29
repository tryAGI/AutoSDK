//HintName: G.Models.LettaStreamingResponseDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaStreamingResponseDiscriminatorMessageType
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
        ErrorMessage,
        /// <summary>
        /// 
        /// </summary>
        HiddenReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        Ping,
        /// <summary>
        /// 
        /// </summary>
        ReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        StopReason,
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
        UsageStatistics,
        /// <summary>
        /// 
        /// </summary>
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