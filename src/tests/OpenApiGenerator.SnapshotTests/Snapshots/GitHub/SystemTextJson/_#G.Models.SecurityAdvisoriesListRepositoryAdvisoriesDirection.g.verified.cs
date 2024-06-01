//HintName: G.Models.SecurityAdvisoriesListRepositoryAdvisoriesDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum SecurityAdvisoriesListRepositoryAdvisoriesDirection
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
    public static class SecurityAdvisoriesListRepositoryAdvisoriesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListRepositoryAdvisoriesDirection value)
        {
            return value switch
            {
                SecurityAdvisoriesListRepositoryAdvisoriesDirection.Asc => "asc",
                SecurityAdvisoriesListRepositoryAdvisoriesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListRepositoryAdvisoriesDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecurityAdvisoriesListRepositoryAdvisoriesDirection.Asc,
                "desc" => SecurityAdvisoriesListRepositoryAdvisoriesDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}