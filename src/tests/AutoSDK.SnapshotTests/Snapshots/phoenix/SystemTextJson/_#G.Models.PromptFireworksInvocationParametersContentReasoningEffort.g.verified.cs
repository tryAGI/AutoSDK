//HintName: G.Models.PromptFireworksInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptFireworksInvocationParametersContentReasoningEffort
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
    public static class PromptFireworksInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptFireworksInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptFireworksInvocationParametersContentReasoningEffort.High => "high",
                PromptFireworksInvocationParametersContentReasoningEffort.Low => "low",
                PromptFireworksInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptFireworksInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptFireworksInvocationParametersContentReasoningEffort.None => "none",
                PromptFireworksInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptFireworksInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptFireworksInvocationParametersContentReasoningEffort.High,
                "low" => PromptFireworksInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptFireworksInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptFireworksInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptFireworksInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptFireworksInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}