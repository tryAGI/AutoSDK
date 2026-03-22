//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewDismissedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}