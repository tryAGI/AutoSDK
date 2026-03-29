//HintName: G.Models.HumeCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HumeCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Hume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HumeCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HumeCredentialProvider value)
        {
            return value switch
            {
                HumeCredentialProvider.Hume => "hume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HumeCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "hume" => HumeCredentialProvider.Hume,
                _ => null,
            };
        }
    }
}