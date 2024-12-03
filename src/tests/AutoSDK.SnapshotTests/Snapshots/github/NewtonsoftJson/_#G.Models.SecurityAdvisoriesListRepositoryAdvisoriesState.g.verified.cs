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
        [global::System.Runtime.Serialization.EnumMember(Value="triage")]
        Triage,
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
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
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
                SecurityAdvisoriesListRepositoryAdvisoriesState.Triage => "triage",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Draft => "draft",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Published => "published",
                SecurityAdvisoriesListRepositoryAdvisoriesState.Closed => "closed",
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
                "triage" => SecurityAdvisoriesListRepositoryAdvisoriesState.Triage,
                "draft" => SecurityAdvisoriesListRepositoryAdvisoriesState.Draft,
                "published" => SecurityAdvisoriesListRepositoryAdvisoriesState.Published,
                "closed" => SecurityAdvisoriesListRepositoryAdvisoriesState.Closed,
                _ => null,
            };
        }
    }
}