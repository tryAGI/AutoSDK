//HintName: G.Models.SlackOAuth2AuthorizationCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SlackOAuth2AuthorizationCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack.oauth2-authorization")]
        SlackOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SlackOAuth2AuthorizationCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SlackOAuth2AuthorizationCredentialProvider value)
        {
            return value switch
            {
                SlackOAuth2AuthorizationCredentialProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SlackOAuth2AuthorizationCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "slack.oauth2-authorization" => SlackOAuth2AuthorizationCredentialProvider.SlackOauth2Authorization,
                _ => null,
            };
        }
    }
}