//HintName: G.Models.CreateChatCompletionStreamResponseChoicesFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
    /// `length` if the maximum number of tokens specified in the request was reached,
    /// `content_filter` if content was omitted due to a flag from our content filters,
    /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionStreamResponseChoicesFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="length")]
        Length,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
        ToolCalls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_filter")]
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionStreamResponseChoicesFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionStreamResponseChoicesFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionStreamResponseChoicesFinishReason.Stop => "stop",
                CreateChatCompletionStreamResponseChoicesFinishReason.Length => "length",
                CreateChatCompletionStreamResponseChoicesFinishReason.ToolCalls => "tool_calls",
                CreateChatCompletionStreamResponseChoicesFinishReason.ContentFilter => "content_filter",
                CreateChatCompletionStreamResponseChoicesFinishReason.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionStreamResponseChoicesFinishReason ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateChatCompletionStreamResponseChoicesFinishReason.Stop,
                "length" => CreateChatCompletionStreamResponseChoicesFinishReason.Length,
                "tool_calls" => CreateChatCompletionStreamResponseChoicesFinishReason.ToolCalls,
                "content_filter" => CreateChatCompletionStreamResponseChoicesFinishReason.ContentFilter,
                "function_call" => CreateChatCompletionStreamResponseChoicesFinishReason.FunctionCall,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}