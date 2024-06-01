//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum SecurityAdvisoriesListGlobalAdvisoriesDirection
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
    public static class SecurityAdvisoriesListGlobalAdvisoriesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListGlobalAdvisoriesDirection value)
        {
            return value switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesDirection.Asc => "asc",
                SecurityAdvisoriesListGlobalAdvisoriesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListGlobalAdvisoriesDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecurityAdvisoriesListGlobalAdvisoriesDirection.Asc,
                "desc" => SecurityAdvisoriesListGlobalAdvisoriesDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}