//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType.Bot,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}