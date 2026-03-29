//HintName: G.Models.ChatCompletionChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model<br/>
    /// hit a natural stop point or a provided stop sequence, `length` if the maximum<br/>
    /// number of tokens specified in the request was reached, `content_filter` if<br/>
    /// content was omitted due to a flag from our content filters, `tool_calls` if the<br/>
    /// model called a tool, or `function_call` (deprecated) if the model called a<br/>
    /// function.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionChoiceFinishReason
    {
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
    public static class ChatCompletionChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChoiceFinishReason value)
        {
            return value switch
            {
                ChatCompletionChoiceFinishReason.ContentFilter => "content_filter",
                ChatCompletionChoiceFinishReason.FunctionCall => "function_call",
                ChatCompletionChoiceFinishReason.Length => "length",
                ChatCompletionChoiceFinishReason.Stop => "stop",
                ChatCompletionChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChatCompletionChoiceFinishReason.ContentFilter,
                "function_call" => ChatCompletionChoiceFinishReason.FunctionCall,
                "length" => ChatCompletionChoiceFinishReason.Length,
                "stop" => ChatCompletionChoiceFinishReason.Stop,
                "tool_calls" => ChatCompletionChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}