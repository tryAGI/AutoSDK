//HintName: G.Models.CreateCloudflareCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Credential provider. Only allowed value is cloudflare
    /// </summary>
    public enum CreateCloudflareCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCloudflareCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCloudflareCredentialDTOProvider value)
        {
            return value switch
            {
                CreateCloudflareCredentialDTOProvider.Cloudflare => "cloudflare",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCloudflareCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "cloudflare" => CreateCloudflareCredentialDTOProvider.Cloudflare,
                _ => null,
            };
        }
    }
}