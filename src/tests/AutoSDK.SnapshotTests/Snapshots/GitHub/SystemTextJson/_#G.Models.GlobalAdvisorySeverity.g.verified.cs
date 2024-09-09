//HintName: G.Models.GlobalAdvisorySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory.
    /// </summary>
    public enum GlobalAdvisorySeverity
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
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
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
                GlobalAdvisorySeverity.Medium => "medium",
                GlobalAdvisorySeverity.Low => "low",
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
                "medium" => GlobalAdvisorySeverity.Medium,
                "low" => GlobalAdvisorySeverity.Low,
                "unknown" => GlobalAdvisorySeverity.Unknown,
                _ => null,
            };
        }
    }
}