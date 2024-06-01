//HintName: G.Models.RepositoryAdvisoryCreateSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
    /// </summary>
    public enum RepositoryAdvisoryCreateSeverity
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
    public static class RepositoryAdvisoryCreateSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryCreateSeverity value)
        {
            return value switch
            {
                RepositoryAdvisoryCreateSeverity.Critical => "critical",
                RepositoryAdvisoryCreateSeverity.High => "high",
                RepositoryAdvisoryCreateSeverity.Medium => "medium",
                RepositoryAdvisoryCreateSeverity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryCreateSeverity ToEnum(string value)
        {
            return value switch
            {
                "critical" => RepositoryAdvisoryCreateSeverity.Critical,
                "high" => RepositoryAdvisoryCreateSeverity.High,
                "medium" => RepositoryAdvisoryCreateSeverity.Medium,
                "low" => RepositoryAdvisoryCreateSeverity.Low,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}