//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}