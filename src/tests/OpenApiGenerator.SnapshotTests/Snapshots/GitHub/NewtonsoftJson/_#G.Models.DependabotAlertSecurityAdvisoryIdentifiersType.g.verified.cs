//HintName: G.Models.DependabotAlertSecurityAdvisoryIdentifiersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of advisory identifier.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertSecurityAdvisoryIdentifiersType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CVE")]
        CVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GHSA")]
        GHSA,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertSecurityAdvisoryIdentifiersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertSecurityAdvisoryIdentifiersType value)
        {
            return value switch
            {
                DependabotAlertSecurityAdvisoryIdentifiersType.CVE => "CVE",
                DependabotAlertSecurityAdvisoryIdentifiersType.GHSA => "GHSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertSecurityAdvisoryIdentifiersType? ToEnum(string value)
        {
            return value switch
            {
                "CVE" => DependabotAlertSecurityAdvisoryIdentifiersType.CVE,
                "GHSA" => DependabotAlertSecurityAdvisoryIdentifiersType.GHSA,
                _ => null,
            };
        }
    }
}