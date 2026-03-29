//HintName: G.Models.ChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChoiceFinishReason
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
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChoiceFinishReason value)
        {
            return value switch
            {
                ChoiceFinishReason.ContentFilter => "content_filter",
                ChoiceFinishReason.FunctionCall => "function_call",
                ChoiceFinishReason.Length => "length",
                ChoiceFinishReason.Stop => "stop",
                ChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChoiceFinishReason.ContentFilter,
                "function_call" => ChoiceFinishReason.FunctionCall,
                "length" => ChoiceFinishReason.Length,
                "stop" => ChoiceFinishReason.Stop,
                "tool_calls" => ChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}