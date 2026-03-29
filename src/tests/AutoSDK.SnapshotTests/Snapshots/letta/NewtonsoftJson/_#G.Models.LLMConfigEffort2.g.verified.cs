//HintName: G.Models.LLMConfigEffort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigEffort2
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
        [global::System.Runtime.Serialization.EnumMember(Value="max")]
        Max,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigEffort2 value)
        {
            return value switch
            {
                LLMConfigEffort2.High => "high",
                LLMConfigEffort2.Low => "low",
                LLMConfigEffort2.Max => "max",
                LLMConfigEffort2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMConfigEffort2.High,
                "low" => LLMConfigEffort2.Low,
                "max" => LLMConfigEffort2.Max,
                "medium" => LLMConfigEffort2.Medium,
                _ => null,
            };
        }
    }
}