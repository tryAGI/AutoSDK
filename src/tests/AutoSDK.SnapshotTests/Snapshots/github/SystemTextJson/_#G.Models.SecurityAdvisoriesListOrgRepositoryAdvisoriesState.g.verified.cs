//HintName: G.Models.SecurityAdvisoriesListOrgRepositoryAdvisoriesState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAdvisoriesListOrgRepositoryAdvisoriesState
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
    public static class SecurityAdvisoriesListOrgRepositoryAdvisoriesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListOrgRepositoryAdvisoriesState value)
        {
            return value switch
            {
                SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Closed => "closed",
                SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Draft => "draft",
                SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Published => "published",
                SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Triage => "triage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListOrgRepositoryAdvisoriesState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Closed,
                "draft" => SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Draft,
                "published" => SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Published,
                "triage" => SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Triage,
                _ => null,
            };
        }
    }
}