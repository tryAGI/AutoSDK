//HintName: G.Models.SecurityAdvisoriesListRepositoryAdvisoriesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum SecurityAdvisoriesListRepositoryAdvisoriesSort
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
    public static class SecurityAdvisoriesListRepositoryAdvisoriesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListRepositoryAdvisoriesSort value)
        {
            return value switch
            {
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Created => "created",
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Updated => "updated",
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListRepositoryAdvisoriesSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => SecurityAdvisoriesListRepositoryAdvisoriesSort.Created,
                "updated" => SecurityAdvisoriesListRepositoryAdvisoriesSort.Updated,
                "published" => SecurityAdvisoriesListRepositoryAdvisoriesSort.Published,
                _ => null,
            };
        }
    }
}