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
    public enum CreateChatCompletionStreamResponseChoicesFinishReason
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

    public static class CreateChatCompletionStreamResponseChoicesFinishReasonExtensions
    {
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
        public static CreateChatCompletionStreamResponseChoicesFinishReason ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionStreamResponseChoicesFinishReason.Stop,
                1 => CreateChatCompletionStreamResponseChoicesFinishReason.Length,
                2 => CreateChatCompletionStreamResponseChoicesFinishReason.ToolCalls,
                3 => CreateChatCompletionStreamResponseChoicesFinishReason.ContentFilter,
                4 => CreateChatCompletionStreamResponseChoicesFinishReason.FunctionCall,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}