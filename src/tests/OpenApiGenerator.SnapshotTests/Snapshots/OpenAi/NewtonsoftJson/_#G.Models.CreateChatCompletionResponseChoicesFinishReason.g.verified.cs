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
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionResponseChoicesFinishReason
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

    public static class CreateChatCompletionResponseChoicesFinishReasonExtensions
    {
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
        public static CreateChatCompletionResponseChoicesFinishReason ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionResponseChoicesFinishReason.Stop,
                1 => CreateChatCompletionResponseChoicesFinishReason.Length,
                2 => CreateChatCompletionResponseChoicesFinishReason.ToolCalls,
                3 => CreateChatCompletionResponseChoicesFinishReason.ContentFilter,
                4 => CreateChatCompletionResponseChoicesFinishReason.FunctionCall,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}