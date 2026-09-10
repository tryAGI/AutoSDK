//HintName: G.Models.ModelReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelReasoningEffort
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
    public static class ModelReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelReasoningEffort value)
        {
            return value switch
            {
                ModelReasoningEffort.High => "high",
                ModelReasoningEffort.Low => "low",
                ModelReasoningEffort.Medium => "medium",
                ModelReasoningEffort.Minimal => "minimal",
                ModelReasoningEffort.None => "none",
                ModelReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelReasoningEffort.High,
                "low" => ModelReasoningEffort.Low,
                "medium" => ModelReasoningEffort.Medium,
                "minimal" => ModelReasoningEffort.Minimal,
                "none" => ModelReasoningEffort.None,
                "xhigh" => ModelReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}