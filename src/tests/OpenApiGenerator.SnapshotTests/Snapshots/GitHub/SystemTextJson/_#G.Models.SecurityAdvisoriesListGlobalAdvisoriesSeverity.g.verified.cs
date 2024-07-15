//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAdvisoriesListGlobalAdvisoriesSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Critical,
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
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Unknown => "unknown",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Low => "low",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Medium => "medium",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.High => "high",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Critical => "critical",
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
                "unknown" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Unknown,
                "low" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Low,
                "medium" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Medium,
                "high" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.High,
                "critical" => SecurityAdvisoriesListGlobalAdvisoriesSeverity.Critical,
                _ => null,
            };
        }
    }
}