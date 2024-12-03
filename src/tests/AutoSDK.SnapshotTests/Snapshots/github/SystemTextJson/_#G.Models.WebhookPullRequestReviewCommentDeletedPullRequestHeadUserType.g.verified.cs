//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}