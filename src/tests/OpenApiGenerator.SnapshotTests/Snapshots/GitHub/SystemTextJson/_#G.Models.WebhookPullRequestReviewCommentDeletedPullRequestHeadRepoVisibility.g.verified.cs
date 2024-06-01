//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}