//HintName: G.Models.PromptGroqInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptGroqInvocationParametersContentReasoningEffort
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
    public static class PromptGroqInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptGroqInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptGroqInvocationParametersContentReasoningEffort.High => "high",
                PromptGroqInvocationParametersContentReasoningEffort.Low => "low",
                PromptGroqInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptGroqInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptGroqInvocationParametersContentReasoningEffort.None => "none",
                PromptGroqInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptGroqInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptGroqInvocationParametersContentReasoningEffort.High,
                "low" => PromptGroqInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptGroqInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptGroqInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptGroqInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptGroqInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}