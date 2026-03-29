//HintName: G.Models.PromptAzureOpenAIInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAzureOpenAIInvocationParametersContentReasoningEffort
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
    public static class PromptAzureOpenAIInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAzureOpenAIInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.High => "high",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Low => "low",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.None => "none",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAzureOpenAIInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.High,
                "low" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}