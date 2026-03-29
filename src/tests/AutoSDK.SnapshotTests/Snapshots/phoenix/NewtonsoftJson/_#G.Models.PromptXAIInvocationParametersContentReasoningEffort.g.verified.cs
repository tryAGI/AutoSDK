//HintName: G.Models.PromptXAIInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptXAIInvocationParametersContentReasoningEffort
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
    public static class PromptXAIInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptXAIInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptXAIInvocationParametersContentReasoningEffort.High => "high",
                PromptXAIInvocationParametersContentReasoningEffort.Low => "low",
                PromptXAIInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptXAIInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptXAIInvocationParametersContentReasoningEffort.None => "none",
                PromptXAIInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptXAIInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptXAIInvocationParametersContentReasoningEffort.High,
                "low" => PromptXAIInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptXAIInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptXAIInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptXAIInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptXAIInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}