//HintName: G.Models.ChatCompletionChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: stop
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionChoiceFinishReason
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
        [global::System.Runtime.Serialization.EnumMember(Value="model_length")]
        ModelLength,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
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
                ChatCompletionChoiceFinishReason.Stop => "stop",
                ChatCompletionChoiceFinishReason.Length => "length",
                ChatCompletionChoiceFinishReason.ModelLength => "model_length",
                ChatCompletionChoiceFinishReason.Error => "error",
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
                "stop" => ChatCompletionChoiceFinishReason.Stop,
                "length" => ChatCompletionChoiceFinishReason.Length,
                "model_length" => ChatCompletionChoiceFinishReason.ModelLength,
                "error" => ChatCompletionChoiceFinishReason.Error,
                "tool_calls" => ChatCompletionChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}