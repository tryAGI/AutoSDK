//HintName: G.Models.ChatFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason a chat request has finished.
    /// </summary>
    public enum ChatFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ContentBlocked,
        /// <summary>
        /// 
        /// </summary>
        ErrorLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFinishReason value)
        {
            return value switch
            {
                ChatFinishReason.Complete => "complete",
                ChatFinishReason.StopSequence => "stop_sequence",
                ChatFinishReason.MaxTokens => "max_tokens",
                ChatFinishReason.ToolCall => "tool_call",
                ChatFinishReason.Error => "error",
                ChatFinishReason.ContentBlocked => "content_blocked",
                ChatFinishReason.ErrorLimit => "error_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "complete" => ChatFinishReason.Complete,
                "stop_sequence" => ChatFinishReason.StopSequence,
                "max_tokens" => ChatFinishReason.MaxTokens,
                "tool_call" => ChatFinishReason.ToolCall,
                "error" => ChatFinishReason.Error,
                "content_blocked" => ChatFinishReason.ContentBlocked,
                "error_limit" => ChatFinishReason.ErrorLimit,
                _ => null,
            };
        }
    }
}