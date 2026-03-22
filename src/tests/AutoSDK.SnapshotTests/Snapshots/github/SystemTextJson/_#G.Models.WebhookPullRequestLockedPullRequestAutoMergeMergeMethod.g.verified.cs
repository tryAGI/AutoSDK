//HintName: G.Models.WebhookPullRequestLockedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestLockedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestLockedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestLockedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestLockedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestLockedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestLockedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}