//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}