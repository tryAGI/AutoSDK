//HintName: G.Models.SecurityAdvisoriesListRepositoryAdvisoriesState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAdvisoriesListRepositoryAdvisoriesState
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Published,
        /// <summary>
        /// 
        /// </summary>
        Triage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAdvisoriesListRepositoryAdvisoriesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListRepositoryAdvisoriesState value)
        {
            return value switch
            {
                SecurityAdvisoriesListRepositoryAdvisoriesState.Closed => "closed",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Draft => "draft",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Published => "published",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Triage => "triage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListRepositoryAdvisoriesState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => SecurityAdvisoriesListRepositoryAdvisoriesState.Closed,
                "draft" => SecurityAdvisoriesListRepositoryAdvisoriesState.Draft,
                "published" => SecurityAdvisoriesListRepositoryAdvisoriesState.Published,
                "triage" => SecurityAdvisoriesListRepositoryAdvisoriesState.Triage,
                _ => null,
            };
        }
    }
}