//HintName: G.Models.CreateChatCompletionResponseChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
    /// `length` if the maximum number of tokens specified in the request was reached,<br/>
    /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionResponseChoiceFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
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
    public static class CreateChatCompletionResponseChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseChoiceFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionResponseChoiceFinishReason.FunctionCall => "function_call",
                CreateChatCompletionResponseChoiceFinishReason.Length => "length",
                CreateChatCompletionResponseChoiceFinishReason.Stop => "stop",
                CreateChatCompletionResponseChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionResponseChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => CreateChatCompletionResponseChoiceFinishReason.FunctionCall,
                "length" => CreateChatCompletionResponseChoiceFinishReason.Length,
                "stop" => CreateChatCompletionResponseChoiceFinishReason.Stop,
                "tool_calls" => CreateChatCompletionResponseChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}