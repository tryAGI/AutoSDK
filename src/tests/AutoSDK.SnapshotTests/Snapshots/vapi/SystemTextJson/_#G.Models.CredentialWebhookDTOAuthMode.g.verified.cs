//HintName: G.Models.CredentialWebhookDTOAuthMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CredentialWebhookDTOAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialWebhookDTOAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialWebhookDTOAuthMode value)
        {
            return value switch
            {
                CredentialWebhookDTOAuthMode.ApiKey => "API_KEY",
                CredentialWebhookDTOAuthMode.Basic => "BASIC",
                CredentialWebhookDTOAuthMode.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialWebhookDTOAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => CredentialWebhookDTOAuthMode.ApiKey,
                "BASIC" => CredentialWebhookDTOAuthMode.Basic,
                "OAUTH2" => CredentialWebhookDTOAuthMode.Oauth2,
                _ => null,
            };
        }
    }
}