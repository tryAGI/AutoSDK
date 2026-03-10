//HintName: G.Models.LLMReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
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
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMReasoningEffort value)
        {
            return value switch
            {
                LLMReasoningEffort.None => "none",
                LLMReasoningEffort.Minimal => "minimal",
                LLMReasoningEffort.Low => "low",
                LLMReasoningEffort.Medium => "medium",
                LLMReasoningEffort.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => LLMReasoningEffort.None,
                "minimal" => LLMReasoningEffort.Minimal,
                "low" => LLMReasoningEffort.Low,
                "medium" => LLMReasoningEffort.Medium,
                "high" => LLMReasoningEffort.High,
                _ => null,
            };
        }
    }
}