//HintName: G.Models.SecurityAdvisoriesListGlobalAdvisoriesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: reviewed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAdvisoriesListGlobalAdvisoriesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reviewed")]
        Reviewed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="malware")]
        Malware,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unreviewed")]
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
        public static SecurityAdvisoriesListGlobalAdvisoriesType ToEnum(string value)
        {
            return value switch
            {
                "reviewed" => SecurityAdvisoriesListGlobalAdvisoriesType.Reviewed,
                "malware" => SecurityAdvisoriesListGlobalAdvisoriesType.Malware,
                "unreviewed" => SecurityAdvisoriesListGlobalAdvisoriesType.Unreviewed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}