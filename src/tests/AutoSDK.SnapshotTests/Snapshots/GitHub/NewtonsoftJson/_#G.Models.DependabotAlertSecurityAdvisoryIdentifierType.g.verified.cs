//HintName: G.Models.DependabotAlertSecurityAdvisoryIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of advisory identifier.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertSecurityAdvisoryIdentifierType
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
    public static class DependabotAlertSecurityAdvisoryIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertSecurityAdvisoryIdentifierType value)
        {
            return value switch
            {
                DependabotAlertSecurityAdvisoryIdentifierType.CVE => "CVE",
                DependabotAlertSecurityAdvisoryIdentifierType.GHSA => "GHSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertSecurityAdvisoryIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "CVE" => DependabotAlertSecurityAdvisoryIdentifierType.CVE,
                "GHSA" => DependabotAlertSecurityAdvisoryIdentifierType.GHSA,
                _ => null,
            };
        }
    }
}