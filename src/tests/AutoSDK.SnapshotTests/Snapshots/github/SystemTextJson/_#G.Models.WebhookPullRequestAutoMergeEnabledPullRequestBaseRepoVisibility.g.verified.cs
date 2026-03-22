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
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
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
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}