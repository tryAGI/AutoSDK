//HintName: G.Models.WebhookGithubAppAuthorizationRevokedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookGithubAppAuthorizationRevokedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="revoked")]
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookGithubAppAuthorizationRevokedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookGithubAppAuthorizationRevokedAction value)
        {
            return value switch
            {
                WebhookGithubAppAuthorizationRevokedAction.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookGithubAppAuthorizationRevokedAction ToEnum(string value)
        {
            return value switch
            {
                "revoked" => WebhookGithubAppAuthorizationRevokedAction.Revoked,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}