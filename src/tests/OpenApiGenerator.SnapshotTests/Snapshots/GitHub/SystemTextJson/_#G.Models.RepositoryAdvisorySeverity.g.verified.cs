//HintName: G.Models.RepositoryAdvisorySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory.
    /// </summary>
    public enum RepositoryAdvisorySeverity
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisorySeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisorySeverity value)
        {
            return value switch
            {
                RepositoryAdvisorySeverity.Critical => "critical",
                RepositoryAdvisorySeverity.High => "high",
                RepositoryAdvisorySeverity.Medium => "medium",
                RepositoryAdvisorySeverity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisorySeverity ToEnum(string value)
        {
            return value switch
            {
                "critical" => RepositoryAdvisorySeverity.Critical,
                "high" => RepositoryAdvisorySeverity.High,
                "medium" => RepositoryAdvisorySeverity.Medium,
                "low" => RepositoryAdvisorySeverity.Low,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}