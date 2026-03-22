//HintName: G.Models.WebhookPullRequestUnlockedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestUnlockedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestUnlockedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestUnlockedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestUnlockedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestUnlockedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestUnlockedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}