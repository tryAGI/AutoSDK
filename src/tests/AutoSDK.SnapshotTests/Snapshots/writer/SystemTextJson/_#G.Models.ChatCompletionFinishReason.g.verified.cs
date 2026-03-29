//HintName: G.Models.ChatCompletionFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionFinishReason value)
        {
            return value switch
            {
                ChatCompletionFinishReason.ContentFilter => "content_filter",
                ChatCompletionFinishReason.Length => "length",
                ChatCompletionFinishReason.Stop => "stop",
                ChatCompletionFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChatCompletionFinishReason.ContentFilter,
                "length" => ChatCompletionFinishReason.Length,
                "stop" => ChatCompletionFinishReason.Stop,
                "tool_calls" => ChatCompletionFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}