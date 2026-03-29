//HintName: G.Models.PromptOpenAIInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptOpenAIInvocationParametersContentReasoningEffort
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
    public static class PromptOpenAIInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptOpenAIInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptOpenAIInvocationParametersContentReasoningEffort.High => "high",
                PromptOpenAIInvocationParametersContentReasoningEffort.Low => "low",
                PromptOpenAIInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptOpenAIInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptOpenAIInvocationParametersContentReasoningEffort.None => "none",
                PromptOpenAIInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptOpenAIInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptOpenAIInvocationParametersContentReasoningEffort.High,
                "low" => PromptOpenAIInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptOpenAIInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptOpenAIInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptOpenAIInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptOpenAIInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}