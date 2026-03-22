//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewCommentEditedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}