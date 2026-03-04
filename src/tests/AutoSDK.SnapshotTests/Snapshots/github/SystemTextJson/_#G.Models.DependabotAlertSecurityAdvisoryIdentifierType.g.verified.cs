//HintName: G.Models.DependabotAlertSecurityAdvisoryIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of advisory identifier.<br/>
    /// Included only in responses
    /// </summary>
    public enum DependabotAlertSecurityAdvisoryIdentifierType
    {
        /// <summary>
        /// 
        /// </summary>
        Cve,
        /// <summary>
        /// 
        /// </summary>
        Ghsa,
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
                DependabotAlertSecurityAdvisoryIdentifierType.Cve => "CVE",
                DependabotAlertSecurityAdvisoryIdentifierType.Ghsa => "GHSA",
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
                "CVE" => DependabotAlertSecurityAdvisoryIdentifierType.Cve,
                "GHSA" => DependabotAlertSecurityAdvisoryIdentifierType.Ghsa,
                _ => null,
            };
        }
    }
}