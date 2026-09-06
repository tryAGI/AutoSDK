//HintName: G.Models.LLMConfigReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMConfigReasoningEffort
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
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigReasoningEffort value)
        {
            return value switch
            {
                LLMConfigReasoningEffort.High => "high",
                LLMConfigReasoningEffort.Low => "low",
                LLMConfigReasoningEffort.Medium => "medium",
                LLMConfigReasoningEffort.Minimal => "minimal",
                LLMConfigReasoningEffort.None => "none",
                LLMConfigReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMConfigReasoningEffort.High,
                "low" => LLMConfigReasoningEffort.Low,
                "medium" => LLMConfigReasoningEffort.Medium,
                "minimal" => LLMConfigReasoningEffort.Minimal,
                "none" => LLMConfigReasoningEffort.None,
                "xhigh" => LLMConfigReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}