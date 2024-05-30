//HintName: G.Models.CreateChatCompletionFunctionResponseChoicesFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, `content_filter` if content was omitted due to a flag from our content filters, or `function_call` if the model called a function.
    /// </summary>
    public enum CreateChatCompletionFunctionResponseChoicesFinishReason
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
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
    }

    public static class CreateChatCompletionFunctionResponseChoicesFinishReasonExtensions
    {
        public static string ToValueString(this CreateChatCompletionFunctionResponseChoicesFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionFunctionResponseChoicesFinishReason.Stop => "stop",
                CreateChatCompletionFunctionResponseChoicesFinishReason.Length => "length",
                CreateChatCompletionFunctionResponseChoicesFinishReason.FunctionCall => "function_call",
                CreateChatCompletionFunctionResponseChoicesFinishReason.ContentFilter => "content_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionFunctionResponseChoicesFinishReason ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateChatCompletionFunctionResponseChoicesFinishReason.Stop,
                "length" => CreateChatCompletionFunctionResponseChoicesFinishReason.Length,
                "function_call" => CreateChatCompletionFunctionResponseChoicesFinishReason.FunctionCall,
                "content_filter" => CreateChatCompletionFunctionResponseChoicesFinishReason.ContentFilter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionFunctionResponseChoicesFinishReason ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionFunctionResponseChoicesFinishReason.Stop,
                1 => CreateChatCompletionFunctionResponseChoicesFinishReason.Length,
                2 => CreateChatCompletionFunctionResponseChoicesFinishReason.FunctionCall,
                3 => CreateChatCompletionFunctionResponseChoicesFinishReason.ContentFilter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}