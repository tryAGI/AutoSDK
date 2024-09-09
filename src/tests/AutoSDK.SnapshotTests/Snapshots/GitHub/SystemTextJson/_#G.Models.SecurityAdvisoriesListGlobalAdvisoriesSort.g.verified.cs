//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: published
    /// </summary>
    public enum SecurityAdvisoriesListGlobalAdvisoriesSort
    {
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
    public static class SecurityAdvisoriesListGlobalAdvisoriesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListGlobalAdvisoriesSort value)
        {
            return value switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesSort.Updated => "updated",
                SecurityAdvisoriesListGlobalAdvisoriesSort.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListGlobalAdvisoriesSort? ToEnum(string value)
        {
            return value switch
            {
                "updated" => SecurityAdvisoriesListGlobalAdvisoriesSort.Updated,
                "published" => SecurityAdvisoriesListGlobalAdvisoriesSort.Published,
                _ => null,
            };
        }
    }
}