//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}