//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}