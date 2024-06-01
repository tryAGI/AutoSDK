//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}