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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}