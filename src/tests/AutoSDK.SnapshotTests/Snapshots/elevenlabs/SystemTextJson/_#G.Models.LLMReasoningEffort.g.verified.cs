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
        /// <summary>
        /// 
        /// </summary>
        None,
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
                LLMReasoningEffort.High => "high",
                LLMReasoningEffort.Low => "low",
                LLMReasoningEffort.Medium => "medium",
                LLMReasoningEffort.Minimal => "minimal",
                LLMReasoningEffort.None => "none",
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
                "high" => LLMReasoningEffort.High,
                "low" => LLMReasoningEffort.Low,
                "medium" => LLMReasoningEffort.Medium,
                "minimal" => LLMReasoningEffort.Minimal,
                "none" => LLMReasoningEffort.None,
                _ => null,
            };
        }
    }
}