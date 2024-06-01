//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}