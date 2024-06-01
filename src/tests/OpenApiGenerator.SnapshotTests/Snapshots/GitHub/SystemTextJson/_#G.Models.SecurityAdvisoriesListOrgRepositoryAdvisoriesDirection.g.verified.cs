//HintName: G.Models.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAdvisoriesListOrgRepositoryAdvisoriesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection value)
        {
            return value switch
            {
                SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection.Asc => "asc",
                SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection.Asc,
                "desc" => SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}