//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}