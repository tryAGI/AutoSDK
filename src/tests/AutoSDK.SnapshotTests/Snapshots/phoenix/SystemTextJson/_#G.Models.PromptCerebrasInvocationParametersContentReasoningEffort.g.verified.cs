//HintName: G.Models.PromptCerebrasInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCerebrasInvocationParametersContentReasoningEffort
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
    public static class PromptCerebrasInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCerebrasInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptCerebrasInvocationParametersContentReasoningEffort.High => "high",
                PromptCerebrasInvocationParametersContentReasoningEffort.Low => "low",
                PromptCerebrasInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptCerebrasInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptCerebrasInvocationParametersContentReasoningEffort.None => "none",
                PromptCerebrasInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCerebrasInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptCerebrasInvocationParametersContentReasoningEffort.High,
                "low" => PromptCerebrasInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptCerebrasInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptCerebrasInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptCerebrasInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptCerebrasInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}