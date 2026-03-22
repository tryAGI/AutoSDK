//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestEnqueuedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}