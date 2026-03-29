//HintName: G.Models.CreateTrieveCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTrieveCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Trieve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTrieveCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTrieveCredentialDTOProvider value)
        {
            return value switch
            {
                CreateTrieveCredentialDTOProvider.Trieve => "trieve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTrieveCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "trieve" => CreateTrieveCredentialDTOProvider.Trieve,
                _ => null,
            };
        }
    }
}