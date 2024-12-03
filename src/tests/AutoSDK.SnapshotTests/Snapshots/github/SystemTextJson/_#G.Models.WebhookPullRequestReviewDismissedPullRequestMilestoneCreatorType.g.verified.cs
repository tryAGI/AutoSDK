//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestMilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}