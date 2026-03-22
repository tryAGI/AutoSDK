//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewEditedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}