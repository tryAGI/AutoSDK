//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}