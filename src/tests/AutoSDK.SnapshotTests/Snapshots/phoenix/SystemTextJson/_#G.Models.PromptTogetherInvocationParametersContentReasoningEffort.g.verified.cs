//HintName: G.Models.PromptTogetherInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptTogetherInvocationParametersContentReasoningEffort
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
    public static class PromptTogetherInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTogetherInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptTogetherInvocationParametersContentReasoningEffort.High => "high",
                PromptTogetherInvocationParametersContentReasoningEffort.Low => "low",
                PromptTogetherInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptTogetherInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptTogetherInvocationParametersContentReasoningEffort.None => "none",
                PromptTogetherInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTogetherInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptTogetherInvocationParametersContentReasoningEffort.High,
                "low" => PromptTogetherInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptTogetherInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptTogetherInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptTogetherInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptTogetherInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}