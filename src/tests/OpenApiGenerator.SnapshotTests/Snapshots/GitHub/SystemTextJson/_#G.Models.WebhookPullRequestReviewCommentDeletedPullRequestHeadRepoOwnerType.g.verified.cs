//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}