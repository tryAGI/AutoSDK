//HintName: G.Models.CreateChatCompletionFunctionResponseChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, `content_filter` if content was omitted due to a flag from our content filters, or `function_call` if the model called a function.
    /// </summary>
    public enum CreateChatCompletionFunctionResponseChoiceFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionFunctionResponseChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionFunctionResponseChoiceFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionFunctionResponseChoiceFinishReason.ContentFilter => "content_filter",
                CreateChatCompletionFunctionResponseChoiceFinishReason.FunctionCall => "function_call",
                CreateChatCompletionFunctionResponseChoiceFinishReason.Length => "length",
                CreateChatCompletionFunctionResponseChoiceFinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionFunctionResponseChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => CreateChatCompletionFunctionResponseChoiceFinishReason.ContentFilter,
                "function_call" => CreateChatCompletionFunctionResponseChoiceFinishReason.FunctionCall,
                "length" => CreateChatCompletionFunctionResponseChoiceFinishReason.Length,
                "stop" => CreateChatCompletionFunctionResponseChoiceFinishReason.Stop,
                _ => null,
            };
        }
    }
}