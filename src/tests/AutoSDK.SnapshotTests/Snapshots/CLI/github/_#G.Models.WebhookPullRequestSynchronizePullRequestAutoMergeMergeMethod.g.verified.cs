//HintName: G.Models.WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}