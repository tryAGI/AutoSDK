//HintName: G.Models.RepositoryAdvisoryIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of identifier.
    /// </summary>
    public enum RepositoryAdvisoryIdentifierType
    {
        /// <summary>
        /// 
        /// </summary>
        CVE,
        /// <summary>
        /// 
        /// </summary>
        GHSA,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryIdentifierType value)
        {
            return value switch
            {
                RepositoryAdvisoryIdentifierType.CVE => "CVE",
                RepositoryAdvisoryIdentifierType.GHSA => "GHSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "CVE" => RepositoryAdvisoryIdentifierType.CVE,
                "GHSA" => RepositoryAdvisoryIdentifierType.GHSA,
                _ => null,
            };
        }
    }
}