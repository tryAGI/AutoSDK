//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestAutoMergeEnabledPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}