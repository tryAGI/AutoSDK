//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestUnlockedPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}