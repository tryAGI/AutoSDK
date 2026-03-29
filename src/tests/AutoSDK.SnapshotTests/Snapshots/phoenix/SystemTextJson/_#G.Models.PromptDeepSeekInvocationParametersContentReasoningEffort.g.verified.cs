//HintName: G.Models.PromptDeepSeekInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptDeepSeekInvocationParametersContentReasoningEffort
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
    public static class PromptDeepSeekInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDeepSeekInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptDeepSeekInvocationParametersContentReasoningEffort.High => "high",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Low => "low",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptDeepSeekInvocationParametersContentReasoningEffort.None => "none",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDeepSeekInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptDeepSeekInvocationParametersContentReasoningEffort.High,
                "low" => PromptDeepSeekInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptDeepSeekInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptDeepSeekInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptDeepSeekInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptDeepSeekInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}