//HintName: G.Models.PromptCerebrasInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCerebrasInvocationParametersContentReasoningEffort
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
    public static class PromptCerebrasInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCerebrasInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptCerebrasInvocationParametersContentReasoningEffort.High => "high",
                PromptCerebrasInvocationParametersContentReasoningEffort.Low => "low",
                PromptCerebrasInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptCerebrasInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptCerebrasInvocationParametersContentReasoningEffort.None => "none",
                PromptCerebrasInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCerebrasInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptCerebrasInvocationParametersContentReasoningEffort.High,
                "low" => PromptCerebrasInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptCerebrasInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptCerebrasInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptCerebrasInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptCerebrasInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}