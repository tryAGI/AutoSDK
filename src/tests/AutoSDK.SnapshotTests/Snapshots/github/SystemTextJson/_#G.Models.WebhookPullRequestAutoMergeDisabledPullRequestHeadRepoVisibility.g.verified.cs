//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}