//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestRequestedTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
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