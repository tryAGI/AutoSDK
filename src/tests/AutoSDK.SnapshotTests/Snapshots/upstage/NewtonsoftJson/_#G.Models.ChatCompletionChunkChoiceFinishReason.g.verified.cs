//HintName: G.Models.ChatCompletionChunkChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionChunkChoiceFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_filter")]
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="length")]
        Length,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionChunkChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChunkChoiceFinishReason value)
        {
            return value switch
            {
                ChatCompletionChunkChoiceFinishReason.ContentFilter => "content_filter",
                ChatCompletionChunkChoiceFinishReason.Length => "length",
                ChatCompletionChunkChoiceFinishReason.Stop => "stop",
                ChatCompletionChunkChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChunkChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChatCompletionChunkChoiceFinishReason.ContentFilter,
                "length" => ChatCompletionChunkChoiceFinishReason.Length,
                "stop" => ChatCompletionChunkChoiceFinishReason.Stop,
                "tool_calls" => ChatCompletionChunkChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}