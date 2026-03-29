//HintName: G.Models.PromptPerplexityInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptPerplexityInvocationParametersContentReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimal")]
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xhigh")]
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptPerplexityInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPerplexityInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptPerplexityInvocationParametersContentReasoningEffort.High => "high",
                PromptPerplexityInvocationParametersContentReasoningEffort.Low => "low",
                PromptPerplexityInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptPerplexityInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptPerplexityInvocationParametersContentReasoningEffort.None => "none",
                PromptPerplexityInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPerplexityInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptPerplexityInvocationParametersContentReasoningEffort.High,
                "low" => PromptPerplexityInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptPerplexityInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptPerplexityInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptPerplexityInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptPerplexityInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}