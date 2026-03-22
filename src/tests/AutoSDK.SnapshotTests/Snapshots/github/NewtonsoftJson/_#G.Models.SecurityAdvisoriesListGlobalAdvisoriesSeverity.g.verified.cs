//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAdvisoriesListGlobalAdvisoriesSeverity
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
    public static class SecurityAdvisoriesListGlobalAdvisoriesSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListGlobalAdvisoriesSeverity value)
        {
            return value switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Critical => "critical",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.High => "high",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Low => "low",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Medium => "medium",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListGlobalAdvisoriesSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Critical,
                "high" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.High,
                "low" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Low,
                "medium" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Medium,
                "unknown" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Unknown,
                _ => null,
            };
        }
    }
}