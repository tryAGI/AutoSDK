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
        Squash,
        /// <summary>
        /// 
        /// </summary>
        Rebase,
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
                WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestDequeuedPullRequestAutoMergeMergeMethod.Rebase,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}