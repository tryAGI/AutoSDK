//HintName: G.Models.CredentialWebhookDTOAuthMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CredentialWebhookDTOAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="API_KEY")]
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASIC")]
        Basic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OAUTH2")]
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