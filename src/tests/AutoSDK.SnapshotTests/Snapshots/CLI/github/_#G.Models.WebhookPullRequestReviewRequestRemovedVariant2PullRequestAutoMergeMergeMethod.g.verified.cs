//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        Squash,
        /// <summary>
        /// 
        /// </summary>
        Rebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}