//HintName: G.Models.LLMRequestBodyReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMRequestBodyReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMRequestBodyReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMRequestBodyReasoningEffort value)
        {
            return value switch
            {
                LLMRequestBodyReasoningEffort.High => "high",
                LLMRequestBodyReasoningEffort.Low => "low",
                LLMRequestBodyReasoningEffort.Medium => "medium",
                LLMRequestBodyReasoningEffort.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMRequestBodyReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMRequestBodyReasoningEffort.High,
                "low" => LLMRequestBodyReasoningEffort.Low,
                "medium" => LLMRequestBodyReasoningEffort.Medium,
                "minimal" => LLMRequestBodyReasoningEffort.Minimal,
                _ => null,
            };
        }
    }
}