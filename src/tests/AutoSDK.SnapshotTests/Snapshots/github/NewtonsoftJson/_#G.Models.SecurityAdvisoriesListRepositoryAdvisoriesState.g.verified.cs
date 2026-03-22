//HintName: G.Models.SecurityAdvisoriesListRepositoryAdvisoriesState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAdvisoriesListRepositoryAdvisoriesState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="published")]
        Published,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="triage")]
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