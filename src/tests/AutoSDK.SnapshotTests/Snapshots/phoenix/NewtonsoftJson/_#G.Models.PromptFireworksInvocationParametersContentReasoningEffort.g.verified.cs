//HintName: G.Models.PromptFireworksInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptFireworksInvocationParametersContentReasoningEffort
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