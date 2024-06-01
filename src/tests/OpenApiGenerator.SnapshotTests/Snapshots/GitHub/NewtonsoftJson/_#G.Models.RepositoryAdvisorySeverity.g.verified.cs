//HintName: G.Models.RepositoryAdvisorySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisorySeverity
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
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
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