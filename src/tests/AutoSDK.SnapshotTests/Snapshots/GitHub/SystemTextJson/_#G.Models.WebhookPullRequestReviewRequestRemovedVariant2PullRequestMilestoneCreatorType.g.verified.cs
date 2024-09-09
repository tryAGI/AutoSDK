//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}