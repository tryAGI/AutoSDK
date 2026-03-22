//HintName: G.Models.GlobalAdvisorySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlobalAdvisorySeverity
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlobalAdvisorySeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalAdvisorySeverity value)
        {
            return value switch
            {
                GlobalAdvisorySeverity.Critical => "critical",
                GlobalAdvisorySeverity.High => "high",
                GlobalAdvisorySeverity.Low => "low",
                GlobalAdvisorySeverity.Medium => "medium",
                GlobalAdvisorySeverity.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalAdvisorySeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => GlobalAdvisorySeverity.Critical,
                "high" => GlobalAdvisorySeverity.High,
                "low" => GlobalAdvisorySeverity.Low,
                "medium" => GlobalAdvisorySeverity.Medium,
                "unknown" => GlobalAdvisorySeverity.Unknown,
                _ => null,
            };
        }
    }
}