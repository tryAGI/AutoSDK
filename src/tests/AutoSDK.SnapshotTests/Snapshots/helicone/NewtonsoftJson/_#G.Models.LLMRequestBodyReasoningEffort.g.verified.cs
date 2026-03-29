//HintName: G.Models.LLMRequestBodyReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMRequestBodyReasoningEffort
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMRequestBodyReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMRequestBodyReasoningEffort value)
        {
            return value switch
            {
                LLMRequestBodyReasoningEffort.High => "high",
                LLMRequestBodyReasoningEffort.Low => "low",
                LLMRequestBodyReasoningEffort.Medium => "medium",
                LLMRequestBodyReasoningEffort.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMRequestBodyReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMRequestBodyReasoningEffort.High,
                "low" => LLMRequestBodyReasoningEffort.Low,
                "medium" => LLMRequestBodyReasoningEffort.Medium,
                "minimal" => LLMRequestBodyReasoningEffort.Minimal,
                _ => null,
            };
        }
    }
}