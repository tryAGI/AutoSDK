//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewEditedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}