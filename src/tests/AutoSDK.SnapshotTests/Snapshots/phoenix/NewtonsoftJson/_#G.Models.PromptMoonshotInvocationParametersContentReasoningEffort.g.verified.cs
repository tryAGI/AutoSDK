//HintName: G.Models.PromptMoonshotInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptMoonshotInvocationParametersContentReasoningEffort
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