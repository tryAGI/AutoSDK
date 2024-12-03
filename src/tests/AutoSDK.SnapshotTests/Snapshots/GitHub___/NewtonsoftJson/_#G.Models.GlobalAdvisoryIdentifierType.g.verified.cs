//HintName: G.Models.GlobalAdvisoryIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of identifier.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlobalAdvisoryIdentifierType
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
    public static class GlobalAdvisoryIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalAdvisoryIdentifierType value)
        {
            return value switch
            {
                GlobalAdvisoryIdentifierType.CVE => "CVE",
                GlobalAdvisoryIdentifierType.GHSA => "GHSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalAdvisoryIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "CVE" => GlobalAdvisoryIdentifierType.CVE,
                "GHSA" => GlobalAdvisoryIdentifierType.GHSA,
                _ => null,
            };
        }
    }
}