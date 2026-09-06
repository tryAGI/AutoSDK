//HintName: G.Models.ExtractConfigPriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractConfigPriority
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
    public static class ExtractConfigPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractConfigPriority value)
        {
            return value switch
            {
                ExtractConfigPriority.Critical => "critical",
                ExtractConfigPriority.High => "high",
                ExtractConfigPriority.Low => "low",
                ExtractConfigPriority.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractConfigPriority? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ExtractConfigPriority.Critical,
                "high" => ExtractConfigPriority.High,
                "low" => ExtractConfigPriority.Low,
                "medium" => ExtractConfigPriority.Medium,
                _ => null,
            };
        }
    }
}