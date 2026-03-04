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
        Cve,
        /// <summary>
        /// 
        /// </summary>
        Ghsa,
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
                RepositoryAdvisoryIdentifierType.Cve => "CVE",
                RepositoryAdvisoryIdentifierType.Ghsa => "GHSA",
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
                "CVE" => RepositoryAdvisoryIdentifierType.Cve,
                "GHSA" => RepositoryAdvisoryIdentifierType.Ghsa,
                _ => null,
            };
        }
    }
}