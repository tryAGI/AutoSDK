//HintName: G.Models.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: created
    /// </summary>
    public enum SecurityAdvisoriesListOrgRepositoryAdvisoriesSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAdvisoriesListOrgRepositoryAdvisoriesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListOrgRepositoryAdvisoriesSort value)
        {
            return value switch
            {
                SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Created => "created",
                SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Updated => "updated",
                SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListOrgRepositoryAdvisoriesSort ToEnum(string value)
        {
            return value switch
            {
                "created" => SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Created,
                "updated" => SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Updated,
                "published" => SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Published,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}