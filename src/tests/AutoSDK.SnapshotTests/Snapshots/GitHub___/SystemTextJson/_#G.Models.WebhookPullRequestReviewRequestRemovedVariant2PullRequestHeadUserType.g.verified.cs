//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}