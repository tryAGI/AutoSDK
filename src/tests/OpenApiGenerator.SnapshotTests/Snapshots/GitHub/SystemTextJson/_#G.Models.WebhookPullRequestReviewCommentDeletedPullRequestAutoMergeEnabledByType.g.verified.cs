//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeEnabledByType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}