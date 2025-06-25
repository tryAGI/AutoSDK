//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}