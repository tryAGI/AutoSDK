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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionFunctionResponseChoicesFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionFunctionResponseChoicesFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateChatCompletionFunctionResponseChoicesFinishReason.Stop,
                "length" => CreateChatCompletionFunctionResponseChoicesFinishReason.Length,
                "function_call" => CreateChatCompletionFunctionResponseChoicesFinishReason.FunctionCall,
                "content_filter" => CreateChatCompletionFunctionResponseChoicesFinishReason.ContentFilter,
                _ => null,
            };
        }
    }
}