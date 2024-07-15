//HintName: G.Models.RepositoryAdvisoryIdentifiersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of identifier.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryIdentifiersType
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
    public static class RepositoryAdvisoryIdentifiersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryIdentifiersType value)
        {
            return value switch
            {
                RepositoryAdvisoryIdentifiersType.CVE => "CVE",
                RepositoryAdvisoryIdentifiersType.GHSA => "GHSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryIdentifiersType? ToEnum(string value)
        {
            return value switch
            {
                "CVE" => RepositoryAdvisoryIdentifiersType.CVE,
                "GHSA" => RepositoryAdvisoryIdentifiersType.GHSA,
                _ => null,
            };
        }
    }
}