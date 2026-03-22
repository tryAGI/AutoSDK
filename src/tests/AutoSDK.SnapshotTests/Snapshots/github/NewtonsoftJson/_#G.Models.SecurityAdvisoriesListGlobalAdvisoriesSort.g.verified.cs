//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: published
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAdvisoriesListGlobalAdvisoriesSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="epss_percentage")]
        EpssPercentage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="epss_percentile")]
        EpssPercentile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="published")]
        Published,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
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
                SecurityAdvisoriesListGlobalAdvisoriesSort.EpssPercentage => "epss_percentage",
                SecurityAdvisoriesListGlobalAdvisoriesSort.EpssPercentile => "epss_percentile",
                SecurityAdvisoriesListGlobalAdvisoriesSort.Published => "published",
                SecurityAdvisoriesListGlobalAdvisoriesSort.Updated => "updated",
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
                "epss_percentage" => SecurityAdvisoriesListGlobalAdvisoriesSort.EpssPercentage,
                "epss_percentile" => SecurityAdvisoriesListGlobalAdvisoriesSort.EpssPercentile,
                "published" => SecurityAdvisoriesListGlobalAdvisoriesSort.Published,
                "updated" => SecurityAdvisoriesListGlobalAdvisoriesSort.Updated,
                _ => null,
            };
        }
    }
}