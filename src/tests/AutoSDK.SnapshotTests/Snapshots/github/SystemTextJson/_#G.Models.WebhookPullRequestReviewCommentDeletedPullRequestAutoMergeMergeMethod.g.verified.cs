//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        Rebase,
        /// <summary>
        /// 
        /// </summary>
        Squash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewCommentDeletedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}