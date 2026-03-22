//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}