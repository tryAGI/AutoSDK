//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: reviewed
    /// </summary>
    public enum SecurityAdvisoriesListGlobalAdvisoriesType
    {
        /// <summary>
        /// 
        /// </summary>
        Reviewed,
        /// <summary>
        /// 
        /// </summary>
        Malware,
        /// <summary>
        /// 
        /// </summary>
        Unreviewed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAdvisoriesListGlobalAdvisoriesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoriesListGlobalAdvisoriesType value)
        {
            return value switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesType.Reviewed => "reviewed",
                SecurityAdvisoriesListGlobalAdvisoriesType.Malware => "malware",
                SecurityAdvisoriesListGlobalAdvisoriesType.Unreviewed => "unreviewed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoriesListGlobalAdvisoriesType? ToEnum(string value)
        {
            return value switch
            {
                "reviewed" => SecurityAdvisoriesListGlobalAdvisoriesType.Reviewed,
                "malware" => SecurityAdvisoriesListGlobalAdvisoriesType.Malware,
                "unreviewed" => SecurityAdvisoriesListGlobalAdvisoriesType.Unreviewed,
                _ => null,
            };
        }
    }
}