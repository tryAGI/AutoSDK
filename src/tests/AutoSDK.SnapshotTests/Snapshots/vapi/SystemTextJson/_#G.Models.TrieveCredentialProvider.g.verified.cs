//HintName: G.Models.TrieveCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrieveCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Trieve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrieveCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrieveCredentialProvider value)
        {
            return value switch
            {
                TrieveCredentialProvider.Trieve => "trieve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrieveCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "trieve" => TrieveCredentialProvider.Trieve,
                _ => null,
            };
        }
    }
}