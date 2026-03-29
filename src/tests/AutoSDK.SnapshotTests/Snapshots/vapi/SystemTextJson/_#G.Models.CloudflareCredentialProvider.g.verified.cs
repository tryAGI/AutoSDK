//HintName: G.Models.CloudflareCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Credential provider. Only allowed value is cloudflare
    /// </summary>
    public enum CloudflareCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloudflareCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloudflareCredentialProvider value)
        {
            return value switch
            {
                CloudflareCredentialProvider.Cloudflare => "cloudflare",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloudflareCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "cloudflare" => CloudflareCredentialProvider.Cloudflare,
                _ => null,
            };
        }
    }
}