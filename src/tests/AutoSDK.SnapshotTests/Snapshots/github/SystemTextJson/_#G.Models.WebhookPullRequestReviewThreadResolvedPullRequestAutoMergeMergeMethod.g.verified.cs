//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}