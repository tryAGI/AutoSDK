//HintName: G.Models.PromptMoonshotInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptMoonshotInvocationParametersContentReasoningEffort
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
    public static class PromptMoonshotInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptMoonshotInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptMoonshotInvocationParametersContentReasoningEffort.High => "high",
                PromptMoonshotInvocationParametersContentReasoningEffort.Low => "low",
                PromptMoonshotInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptMoonshotInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptMoonshotInvocationParametersContentReasoningEffort.None => "none",
                PromptMoonshotInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptMoonshotInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptMoonshotInvocationParametersContentReasoningEffort.High,
                "low" => PromptMoonshotInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptMoonshotInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptMoonshotInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptMoonshotInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptMoonshotInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}