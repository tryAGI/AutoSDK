//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}