//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}