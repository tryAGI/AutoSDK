//HintName: G.Models.CompletionResponseStreamChoiceFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionResponseStreamChoiceFinishReason
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
        Error,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionResponseStreamChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionResponseStreamChoiceFinishReason value)
        {
            return value switch
            {
                CompletionResponseStreamChoiceFinishReason.Stop => "stop",
                CompletionResponseStreamChoiceFinishReason.Length => "length",
                CompletionResponseStreamChoiceFinishReason.Error => "error",
                CompletionResponseStreamChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionResponseStreamChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => CompletionResponseStreamChoiceFinishReason.Stop,
                "length" => CompletionResponseStreamChoiceFinishReason.Length,
                "error" => CompletionResponseStreamChoiceFinishReason.Error,
                "tool_calls" => CompletionResponseStreamChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}