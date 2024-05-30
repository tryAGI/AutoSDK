//HintName: G.Models.CreateChatCompletionResponseChoicesFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
    /// `length` if the maximum number of tokens specified in the request was reached,
    /// `content_filter` if content was omitted due to a flag from our content filters,
    /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
    /// </summary>
    public enum CreateChatCompletionResponseChoicesFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionResponseChoicesFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseChoicesFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionResponseChoicesFinishReason.Stop => "stop",
                CreateChatCompletionResponseChoicesFinishReason.Length => "length",
                CreateChatCompletionResponseChoicesFinishReason.ToolCalls => "tool_calls",
                CreateChatCompletionResponseChoicesFinishReason.ContentFilter => "content_filter",
                CreateChatCompletionResponseChoicesFinishReason.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionResponseChoicesFinishReason ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateChatCompletionResponseChoicesFinishReason.Stop,
                "length" => CreateChatCompletionResponseChoicesFinishReason.Length,
                "tool_calls" => CreateChatCompletionResponseChoicesFinishReason.ToolCalls,
                "content_filter" => CreateChatCompletionResponseChoicesFinishReason.ContentFilter,
                "function_call" => CreateChatCompletionResponseChoicesFinishReason.FunctionCall,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}