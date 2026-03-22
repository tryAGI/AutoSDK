//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestUnassignedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}