//HintName: G.Models.LLMConfigReasoningEffort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigReasoningEffort2
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
    public static class LLMConfigReasoningEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigReasoningEffort2 value)
        {
            return value switch
            {
                LLMConfigReasoningEffort2.High => "high",
                LLMConfigReasoningEffort2.Low => "low",
                LLMConfigReasoningEffort2.Medium => "medium",
                LLMConfigReasoningEffort2.Minimal => "minimal",
                LLMConfigReasoningEffort2.None => "none",
                LLMConfigReasoningEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigReasoningEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMConfigReasoningEffort2.High,
                "low" => LLMConfigReasoningEffort2.Low,
                "medium" => LLMConfigReasoningEffort2.Medium,
                "minimal" => LLMConfigReasoningEffort2.Minimal,
                "none" => LLMConfigReasoningEffort2.None,
                "xhigh" => LLMConfigReasoningEffort2.Xhigh,
                _ => null,
            };
        }
    }
}