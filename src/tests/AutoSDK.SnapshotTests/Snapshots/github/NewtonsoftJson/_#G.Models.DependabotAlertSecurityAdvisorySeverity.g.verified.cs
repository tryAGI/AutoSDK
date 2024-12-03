//HintName: G.Models.DependabotAlertSecurityAdvisorySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory.<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertSecurityAdvisorySeverity
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
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
                DependabotAlertSecurityAdvisorySeverity.Low => "low",
                DependabotAlertSecurityAdvisorySeverity.Medium => "medium",
                DependabotAlertSecurityAdvisorySeverity.High => "high",
                DependabotAlertSecurityAdvisorySeverity.Critical => "critical",
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
                "low" => DependabotAlertSecurityAdvisorySeverity.Low,
                "medium" => DependabotAlertSecurityAdvisorySeverity.Medium,
                "high" => DependabotAlertSecurityAdvisorySeverity.High,
                "critical" => DependabotAlertSecurityAdvisorySeverity.Critical,
                _ => null,
            };
        }
    }
}