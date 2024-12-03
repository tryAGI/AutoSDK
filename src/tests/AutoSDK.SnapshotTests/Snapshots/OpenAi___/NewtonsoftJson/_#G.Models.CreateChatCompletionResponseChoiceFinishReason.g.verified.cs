//HintName: G.Models.CreateChatCompletionResponseChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
    /// `length` if the maximum number of tokens specified in the request was reached,<br/>
    /// `content_filter` if content was omitted due to a flag from our content filters,<br/>
    /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionResponseChoiceFinishReason
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
    public static class CreateChatCompletionResponseChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseChoiceFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionResponseChoiceFinishReason.Stop => "stop",
                CreateChatCompletionResponseChoiceFinishReason.Length => "length",
                CreateChatCompletionResponseChoiceFinishReason.ToolCalls => "tool_calls",
                CreateChatCompletionResponseChoiceFinishReason.ContentFilter => "content_filter",
                CreateChatCompletionResponseChoiceFinishReason.FunctionCall => "function_call",
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
                "stop" => CreateChatCompletionResponseChoiceFinishReason.Stop,
                "length" => CreateChatCompletionResponseChoiceFinishReason.Length,
                "tool_calls" => CreateChatCompletionResponseChoiceFinishReason.ToolCalls,
                "content_filter" => CreateChatCompletionResponseChoiceFinishReason.ContentFilter,
                "function_call" => CreateChatCompletionResponseChoiceFinishReason.FunctionCall,
                _ => null,
            };
        }
    }
}