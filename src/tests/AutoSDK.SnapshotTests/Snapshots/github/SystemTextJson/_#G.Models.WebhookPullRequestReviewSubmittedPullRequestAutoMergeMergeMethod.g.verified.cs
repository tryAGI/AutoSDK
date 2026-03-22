//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}