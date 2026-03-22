//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}