//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}