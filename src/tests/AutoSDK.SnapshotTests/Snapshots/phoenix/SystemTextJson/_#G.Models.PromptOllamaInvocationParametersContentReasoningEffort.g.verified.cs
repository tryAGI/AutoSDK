//HintName: G.Models.PromptOllamaInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptOllamaInvocationParametersContentReasoningEffort
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
    public static class PromptOllamaInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptOllamaInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptOllamaInvocationParametersContentReasoningEffort.High => "high",
                PromptOllamaInvocationParametersContentReasoningEffort.Low => "low",
                PromptOllamaInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptOllamaInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptOllamaInvocationParametersContentReasoningEffort.None => "none",
                PromptOllamaInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptOllamaInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptOllamaInvocationParametersContentReasoningEffort.High,
                "low" => PromptOllamaInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptOllamaInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptOllamaInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptOllamaInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptOllamaInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}