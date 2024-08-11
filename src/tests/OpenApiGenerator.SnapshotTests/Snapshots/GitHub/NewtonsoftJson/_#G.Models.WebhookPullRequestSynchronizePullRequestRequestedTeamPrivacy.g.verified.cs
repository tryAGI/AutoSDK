//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}