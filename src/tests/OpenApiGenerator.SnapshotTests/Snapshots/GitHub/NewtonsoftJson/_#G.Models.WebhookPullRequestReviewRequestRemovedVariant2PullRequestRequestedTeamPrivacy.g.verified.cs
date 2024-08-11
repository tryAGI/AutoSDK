//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}