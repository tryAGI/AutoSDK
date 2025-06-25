//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestUnlabeledPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}