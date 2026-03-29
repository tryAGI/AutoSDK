//HintName: G.Models.ReasoningEffortEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningEffortEnum
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
    public static class ReasoningEffortEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortEnum value)
        {
            return value switch
            {
                ReasoningEffortEnum.High => "high",
                ReasoningEffortEnum.Low => "low",
                ReasoningEffortEnum.Medium => "medium",
                ReasoningEffortEnum.Minimal => "minimal",
                ReasoningEffortEnum.None => "none",
                ReasoningEffortEnum.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffortEnum.High,
                "low" => ReasoningEffortEnum.Low,
                "medium" => ReasoningEffortEnum.Medium,
                "minimal" => ReasoningEffortEnum.Minimal,
                "none" => ReasoningEffortEnum.None,
                "xhigh" => ReasoningEffortEnum.Xhigh,
                _ => null,
            };
        }
    }
}