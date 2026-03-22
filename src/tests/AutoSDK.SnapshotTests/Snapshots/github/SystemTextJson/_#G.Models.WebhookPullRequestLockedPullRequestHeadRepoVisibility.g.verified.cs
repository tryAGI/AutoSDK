//HintName: G.Models.WebhookPullRequestLockedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestLockedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestLockedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestLockedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestLockedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestLockedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestLockedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}