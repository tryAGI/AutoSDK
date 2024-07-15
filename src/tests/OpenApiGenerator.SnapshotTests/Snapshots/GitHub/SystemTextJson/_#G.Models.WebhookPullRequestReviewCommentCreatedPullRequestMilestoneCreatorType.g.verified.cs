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
                WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
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
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}