//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}