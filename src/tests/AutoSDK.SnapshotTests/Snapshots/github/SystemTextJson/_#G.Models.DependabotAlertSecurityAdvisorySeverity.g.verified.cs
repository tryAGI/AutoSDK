//HintName: G.Models.DependabotAlertSecurityAdvisorySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory.<br/>
    /// Included only in responses
    /// </summary>
    public enum DependabotAlertSecurityAdvisorySeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertSecurityAdvisorySeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertSecurityAdvisorySeverity value)
        {
            return value switch
            {
                DependabotAlertSecurityAdvisorySeverity.Critical => "critical",
                DependabotAlertSecurityAdvisorySeverity.High => "high",
                DependabotAlertSecurityAdvisorySeverity.Low => "low",
                DependabotAlertSecurityAdvisorySeverity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertSecurityAdvisorySeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => DependabotAlertSecurityAdvisorySeverity.Critical,
                "high" => DependabotAlertSecurityAdvisorySeverity.High,
                "low" => DependabotAlertSecurityAdvisorySeverity.Low,
                "medium" => DependabotAlertSecurityAdvisorySeverity.Medium,
                _ => null,
            };
        }
    }
}