//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType.Bot,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}