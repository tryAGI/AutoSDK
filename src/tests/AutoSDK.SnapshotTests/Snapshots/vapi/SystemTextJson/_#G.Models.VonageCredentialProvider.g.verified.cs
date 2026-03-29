//HintName: G.Models.VonageCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VonageCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VonageCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VonageCredentialProvider value)
        {
            return value switch
            {
                VonageCredentialProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VonageCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "vonage" => VonageCredentialProvider.Vonage,
                _ => null,
            };
        }
    }
}