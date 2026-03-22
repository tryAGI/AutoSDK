//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}