//HintName: G.Models.CreateChatCompletionStreamResponseChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
    /// `length` if the maximum number of tokens specified in the request was reached,<br/>
    /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
    /// </summary>
    public enum CreateChatCompletionStreamResponseChoiceFinishReason
    {
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
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionStreamResponseChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionStreamResponseChoiceFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionStreamResponseChoiceFinishReason.FunctionCall => "function_call",
                CreateChatCompletionStreamResponseChoiceFinishReason.Length => "length",
                CreateChatCompletionStreamResponseChoiceFinishReason.Stop => "stop",
                CreateChatCompletionStreamResponseChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionStreamResponseChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => CreateChatCompletionStreamResponseChoiceFinishReason.FunctionCall,
                "length" => CreateChatCompletionStreamResponseChoiceFinishReason.Length,
                "stop" => CreateChatCompletionStreamResponseChoiceFinishReason.Stop,
                "tool_calls" => CreateChatCompletionStreamResponseChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}