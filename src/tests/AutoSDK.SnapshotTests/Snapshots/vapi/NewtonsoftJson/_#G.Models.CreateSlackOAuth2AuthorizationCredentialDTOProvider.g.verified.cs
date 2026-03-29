//HintName: G.Models.CreateSlackOAuth2AuthorizationCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSlackOAuth2AuthorizationCredentialDTOProvider
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
    public static class CreateSlackOAuth2AuthorizationCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSlackOAuth2AuthorizationCredentialDTOProvider value)
        {
            return value switch
            {
                CreateSlackOAuth2AuthorizationCredentialDTOProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSlackOAuth2AuthorizationCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "slack.oauth2-authorization" => CreateSlackOAuth2AuthorizationCredentialDTOProvider.SlackOauth2Authorization,
                _ => null,
            };
        }
    }
}