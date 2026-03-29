//HintName: G.Models.ExtractConfigPriority2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractConfigPriority2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractConfigPriority2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractConfigPriority2 value)
        {
            return value switch
            {
                ExtractConfigPriority2.Critical => "critical",
                ExtractConfigPriority2.High => "high",
                ExtractConfigPriority2.Low => "low",
                ExtractConfigPriority2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractConfigPriority2? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ExtractConfigPriority2.Critical,
                "high" => ExtractConfigPriority2.High,
                "low" => ExtractConfigPriority2.Low,
                "medium" => ExtractConfigPriority2.Medium,
                _ => null,
            };
        }
    }
}