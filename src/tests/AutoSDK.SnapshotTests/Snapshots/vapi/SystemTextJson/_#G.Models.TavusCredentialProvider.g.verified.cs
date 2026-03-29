//HintName: G.Models.TavusCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TavusCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Tavus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TavusCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TavusCredentialProvider value)
        {
            return value switch
            {
                TavusCredentialProvider.Tavus => "tavus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TavusCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "tavus" => TavusCredentialProvider.Tavus,
                _ => null,
            };
        }
    }
}