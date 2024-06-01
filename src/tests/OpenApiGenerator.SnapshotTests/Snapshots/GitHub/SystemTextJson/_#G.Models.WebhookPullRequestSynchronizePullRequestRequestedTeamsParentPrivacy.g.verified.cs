//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedTeamsParentPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}