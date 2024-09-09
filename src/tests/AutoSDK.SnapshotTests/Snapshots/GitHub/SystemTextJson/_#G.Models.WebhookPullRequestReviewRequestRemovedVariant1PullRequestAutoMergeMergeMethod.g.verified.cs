//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}