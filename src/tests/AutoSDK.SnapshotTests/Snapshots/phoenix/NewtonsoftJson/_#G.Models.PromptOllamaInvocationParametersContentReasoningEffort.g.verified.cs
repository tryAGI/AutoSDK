//HintName: G.Models.PromptOllamaInvocationParametersContentReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptOllamaInvocationParametersContentReasoningEffort
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