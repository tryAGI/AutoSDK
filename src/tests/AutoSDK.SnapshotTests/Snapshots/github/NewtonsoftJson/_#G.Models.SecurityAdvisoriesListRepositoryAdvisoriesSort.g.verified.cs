//HintName: G.Models.SecurityAdvisoriesListRepositoryAdvisoriesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAdvisoriesListRepositoryAdvisoriesSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
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
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Published => "published",
                SecurityAdvisoriesListRepositoryAdvisoriesSort.Updated => "updated",
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
                "published" => SecurityAdvisoriesListRepositoryAdvisoriesSort.Published,
                "updated" => SecurityAdvisoriesListRepositoryAdvisoriesSort.Updated,
                _ => null,
            };
        }
    }
}